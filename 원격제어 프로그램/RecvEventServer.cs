using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace 원격제어_프로그램
{
    /*
     키보드 마우스 이벤트 수신 구현
     */

    class RecvEventServer
    {
        Socket lisSock;
        public event RecvKMEEventHandler RecvedKMEvent = null;

        public RecvEventServer(String ip, int port)
        {
            lisSock = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

            IPAddress ipaddr = IPAddress.Parse(ip);
            IPEndPoint ep = new IPEndPoint(ipaddr, port);

            lisSock.Bind(ep);
            lisSock.Listen(5);
            lisSock.BeginAccept(DoAccept, null);
        }

        private void DoAccept(IAsyncResult result)
        {
            if(lisSock != null)
            {
                Socket dosock = lisSock.EndAccept(result);

                //또 다른 클라이언트가 요청할 수 있기에 다시 BeginAccept
                lisSock.BeginAccept(DoAccept,null);
                Receive(dosock);
            }
        }

        private void Receive(Socket dosock)
        {
            byte[] buffer = new byte[9];
            int n = dosock.Receive(buffer);
            if(RecvedKMEvent != null)
            {
                RecvKMEEventArgs e = new RecvKMEEventArgs(new Meta(buffer));
                RecvedKMEvent(this, e);
            }

            dosock.Close();
        }

        public void Close()
        {
            if(lisSock != null)
            {
                lisSock.Close();
                lisSock = null;
            }
        }
    }
}
