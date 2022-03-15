//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;

//namespace 원격제어_프로그램
//{
//    public delegate void RecvRCInfoEventHandler(object sender, RecvRCInfoEventArgs e);

//    public class RecvRCInfoEventArgs :EventArgs
//    {
//        public IPEndPoint iPEndPoint
//        {
//            get;
//            private set;
//        }

//        public string IPAddressStr
//        {
//            get
//            {
//                return iPEndPoint.Address.ToString();
//            }
//        }

//        public int Port
//        {
//            get
//            {
//                return iPEndPoint.Port;
//            }
//        }

//        public RecvRCInfoEventArgs(EndPoint RemoteEndPoint)
//        {
//            iPEndPoint = RemoteEndPoint as IPEndPoint;

//        }
//    }
//}
