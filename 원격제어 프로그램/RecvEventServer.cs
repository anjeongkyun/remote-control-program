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
        Socket lis_sock;
        public event RecvKMEEventHandler RecvedKMEvent = null;

        public RecvEventServer(String ip, int port)
        {
            lis_sock = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

            IPAddress ipaddr = IPAddress.Parse(ip);
            IPEndPoint ep = new IPEndPoint(ipaddr, port);

            lis_sock.Bind(ep);
            lis_sock.Listen(5);
            lis_sock.BeginAccept(DoAccept, null);
        }

        private void DoAccept(IAsyncResult result)
        {
            if(lis_sock != null)
            {
                Socket dosock = lis_sock.EndAccept(result);

                //또 다른 클라이언트가 요청할 수 있기에 다시 BeginAccept
                lis_sock.BeginAccept(DoAccept,null);
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
            if(lis_sock != null)
            {
                lis_sock.Close();
                lis_sock = null;
            }
        }
    }
}
