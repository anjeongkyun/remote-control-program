using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace 원격제어_프로그램
{
    public class ImageServer
    {
        Socket lis_sock = null;
        public event RecvImageEventHandler RecvedImage = null;

        public ImageServer(string ip, int port)
        {
            lis_sock = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipaddr = IPAddress.Parse(ip);
            IPEndPoint ep = new IPEndPoint(ipaddr, port);
            lis_sock.Bind(ep);
            lis_sock.Listen(5);
            lis_sock.BeginAccept(DoAccept, null);


        }

        private void DoAccept(IAsyncResult result)
        {
            if(lis_sock == null)
                return;

            try
            {
                Socket dosock = lis_sock.EndAccept(result);
                Receive(dosock);
                //다시 클라이언트 접속할 수 있으니 BeginAccept
                lis_sock.BeginAccept(DoAccept, null);
            }
            catch
            {
                Close();
            }
        }

        public  void Close()
        {
            if(lis_sock == null)
            {
                lis_sock.Close();
                lis_sock = null;
            }
        }

        private void Receive(Socket dosock)
        {
            byte[] lis_buf = new byte[4];
            dosock.Receive(lis_buf);

            int len = BitConverter.ToInt32(lis_buf, 0);
            byte[] buffer = new byte[len];

            int trans = 0;

            //아래 내용 이해하기
            while (trans < len)
            {
                trans += dosock.Receive(buffer, trans, len - trans, SocketFlags.None);
            }

            if(RecvedImage != null)
            {
                IPEndPoint ep = dosock.RemoteEndPoint as IPEndPoint;
                RecvImageEventArgs e = new RecvImageEventArgs(ep, ConvertBitmap(buffer));
                RecvedImage(this, e);
            }
        }

        private Bitmap ConvertBitmap(byte[] buff)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(buff, 0, (int)buff.Length);

            Bitmap bitmap = new Bitmap(ms);

            return bitmap;
        }
    }
}
