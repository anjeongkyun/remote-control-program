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
        Socket lisSock = null;
        public event RecvImageEventHandler RecvedImage = null;

        public ImageServer(string ip, int port)
        {
            lisSock = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipaddr = IPAddress.Parse(ip);
            IPEndPoint ep = new IPEndPoint(ipaddr, port);
            lisSock.Bind(ep);
            lisSock.Listen(5);
            lisSock.BeginAccept(DoAccept, null);


        }

        private void DoAccept(IAsyncResult result)
        {
            if(lisSock == null)
                return;

            try
            {
                Socket dosock = lisSock.EndAccept(result);
                Receive(dosock);
                //다시 클라이언트 접속할 수 있으니 BeginAccept
                lisSock.BeginAccept(DoAccept, null);
            }
            catch
            {
                Close();
            }
        }

        public  void Close()
        {
            if(lisSock == null)
            {
                lisSock.Close();
                lisSock = null;
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
