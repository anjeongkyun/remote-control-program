using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace 원격제어_프로그램
{
    public class ImageClient
    {
        Socket sock = null;
        public void Connect(string ip, int port)
        {
            IPAddress ipaddr = IPAddress.Parse(ip);
            IPEndPoint ep = new IPEndPoint(ipaddr, port);

            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //비동기로 바꿔보기!
            sock.Connect(ep);
        }

        //동기로 보내기
        public bool SendImage(Image img)
        {
            if (sock == null)
                return false;

            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Jpeg);
            byte[] data = ms.GetBuffer();

            try
            {
                int trans = 0;
                byte[] img_buf = BitConverter.GetBytes(data.Length);
                //전송할 이미지 길이를 먼저 전송한다.
                sock.Send(img_buf);

                while (trans < data.Length)
                {
                    // 이 부분 이해 필요!
                    trans += sock.Send(data, trans, data.Length - trans, SocketFlags.None);
                }

                Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public delegate bool SendImageDele(Image img);

        //비동기로 이미지 보내기
        public void SendImageAsync(Image img, AsyncCallback callback)
        {
            SendImageDele dele = SendImage;
            dele.BeginInvoke(img, callback, this);
        }

        public void Close()
        {
            if(sock != null)
            {
                sock.Close();
                sock = null;
            }
        }
    }
}
