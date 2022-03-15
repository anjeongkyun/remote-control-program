using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace 원격제어_프로그램
{
    public static class SetupClient
    {
        public static event EventHandler ConnectedEventHandler = null;
        public static event EventHandler ConnectFiledEventHandler = null;

        static Socket sock = null;

        public static void Setup(string ip, int port)
        {
            IPAddress ipaddr = IPAddress.Parse(ip);
            IPEndPoint ep = new IPEndPoint(ipaddr, port);

            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //비동기 Connect
            sock.BeginConnect(ep, DoConnect, null);
        }

        /// <summary>
        /// 비동기 Connect 함수
        /// </summary>
        /// <param name="result"></param>
        static void DoConnect(IAsyncResult result)
        {
            IAsyncResult ar = result;

            try
            {
                sock.EndConnect(result);
                //비동기니까 값이 없을 수도 있으니 이벤트 핸들러 null 체크
                if(ConnectedEventHandler != null)
                {
                    ConnectedEventHandler(null, new EventArgs());
                }
            }
            catch (SocketException sock_ex)
            {
                if(ConnectFiledEventHandler != null)
                {
                    ConnectFiledEventHandler(null, new EventArgs());
                }
            }
            sock.Close();
        }

    }
}
