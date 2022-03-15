using MyDemoLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace 원격제어_프로그램
{
    /*
        단일체 객체로 사용하기 위해 싱글톤 패턴을 사용함.
     */

    public class Remote
    {

        public string MyIP
        {
            get
            {
                return NetworkInfo.DefaultIP;
            }
        }

        public event RecvRCInfoEventHandler RecvedRCInfo = null;
        public event RecvKMEEventHandler RecvedKMEvent = null;

        RecvEventServer res = null;

        /// <summary>
        /// 사각영역 객체 생성
        /// </summary>
        public Rectangle Rect
        {
            get;
            private set;
        }

        static Remote singleton = null;

        public static Remote Singleton
        {
            get
            {
                return singleton;
            }
        }
        static Remote()
        {
            singleton = new Remote();
        }

        private Remote()
        {
            //바탕화면 영역
            AutomationElement ae = AutomationElement.RootElement;
            System.Windows.Rect rt = ae.Current.BoundingRectangle;

            Rect = new Rectangle((int)rt.Left, (int)rt.Top, (int)rt.Width, (int)rt.Height);

            SetupServer.RecvedRCInfoEventHandler += SetupServer_RecvedRCInfoEventHandler;
            SetupServer.Start(MyIP, NetworkInfo.SetupPort);
        }

        private void SetupServer_RecvedRCInfoEventHandler(object sender, RecvRCInfoEventArgs e)
        {
            RecvedRCInfo(this, e);
        }

        public void RecvEventStart()
        {
            res = new RecvEventServer(MyIP, NetworkInfo.EventPort);
            res.RecvedKMEvent += Res_RecvedKMEvent;
        }

        private void Res_RecvedKMEvent(object sender, RecvKMEEventArgs e)
        {
            if(RecvedKMEvent != null)
            {
                RecvedKMEvent(this, e);
            }

            switch (e.MT)
            {
                case MsgType.MT_KDOWN:
                    WrapNative.KeyDown(e.Key);
                    break;
                case MsgType.MT_KEYUP:
                    WrapNative.KeyUp(e.Key);
                    break;
                case MsgType.MT_M_LEFTDOWN:
                    WrapNative.LeftDown();
                    break;
                case MsgType.MT_M_LEFTUP:
                    WrapNative.LeftUp();
                    break;
                case MsgType.MT_M_MOVE:
                    WrapNative.Move(e.Now);
                    break;
                default:
                    break;
            }
        }

        public void Stop()
        {
            SetupServer.Close();
            if(res != null)
            {
                res.Close();
                res = null;
            }
        }
    }
}
