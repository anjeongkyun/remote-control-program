using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace 원격제어_프로그램
{
    /// <summary>
    /// 이미지 수신 처리를 위한 대리자
    /// </summary>
    /// <param name="sender">이벤트 통보 개체(게시자)</param>
    /// <param name="e">이벤트 처리 인자</param>
    public delegate void RecvImageEventHandler(object sender, RecvImageEventArgs e);

    /// <summary>
    /// 이미지 수신 이벤트 인자 클래스
    /// </summary>
    public class RecvImageEventArgs : EventArgs
    {
        /// <summary>
        /// IP 단말 인자  - 가져오기
        /// </summary>
        public IPEndPoint IPEndPoint
        {
            get;
            private set;
        }

        /// <summary>
        /// IP 주소  - 가져오기
        /// </summary>
        public IPAddress IPAddress
        {
            get
            {
                return IPEndPoint.Address;
            }
        }

        /// <summary>
        /// IP 주소 문자열 - 가져오기
        /// </summary>
        public string IPAddressStr
        {
            get
            {
                return IPAddress.ToString();
            }
        }

        public int Port
        {
            get
            {
                return IPEndPoint.Port;
            }
        }
        
        public Image Image
        {
            get;
            private set;
        }

        public Size size
        {
            get
            {
                return Image.Size;
            }
        }

        public int Width
        {
            get
            {
                return Image.Width;
            }
        }

        public int Height
        {
            get
            {
                return Image.Height;
            }
        }

        /// <summary>
        /// 이미지 수신 이벤트 인자 클래스
        /// </summary>
        /// <param name="ep">상대측 IPEndPoint</param>
        /// <param name="img">이미지</param>
        public RecvImageEventArgs(IPEndPoint ep, Image img)
        {
            IPEndPoint = ep;
            Image = img;
        }

        public override string ToString()
        {
            return string.Format("IP : {0} width : {1} height : {2}", IPEndPoint, Width,Height);
        }
    }
}
