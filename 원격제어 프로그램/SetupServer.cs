using MyDemoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace 원격제어_프로그램
{
    class SetupServer
    {
        static Socket lis_sock;
        public static event RecvRCInfoEventHandler RecvedRCInfoEventHandler = null;
        static string ip = string.Empty;
        static int port = -1;

        public static void Start(string ip, int port)
        {
            SetupServer.ip = ip;
            SetupServer.port = port;
            SocketBooting();

        }

        private static void SocketBooting()
        {
            IPAddress ipaddr = IPAddress.Parse(ip);
            IPEndPoint ep = new IPEndPoint(ipaddr, port);
            lis_sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            lis_sock.Bind(ep);
            lis_sock.Listen(10);
            lis_sock.BeginAccept(DoAccept, null);
        }

        private static void DoAccept(IAsyncResult result)
        {
            if (lis_sock == null)
                return;

            try
            {
                Socket sock = lis_sock.EndAccept(result);
                DoIt(sock);
                lis_sock.BeginAccept(DoAccept, null);

            }
            catch (Exception ex)
            {
                Close();
            }
        }

        private static void DoIt(Socket dosock)
        {
            if(RecvedRCInfoEventHandler != null)
            {
                RecvRCInfoEventArgs e = new RecvRCInfoEventArgs(dosock.RemoteEndPoint);
                RecvedRCInfoEventHandler(null, e);
            }
            dosock.Close();
        }

        public static void Close()
        {
            if(lis_sock != null)
            {
                lis_sock.Close();
                lis_sock = null;
            }
        }
    }
}
