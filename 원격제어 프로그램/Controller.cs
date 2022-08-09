using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 원격제어_프로그램
{
    class Controller
    {

        ImageServer imgServer = null;
        SendEventClient sce = null;
        public event RecvImageEventHandler RecvedImage = null;
        string host_ip;
        static Controller singleton;

        public static Controller Singleton
        {
            get
            {
                return singleton;
            }
        }

        static Controller()
        {
            singleton = new Controller();
        }

        private Controller()
        {

        }

        public SendEventClient SencEventClient
        {
            get
            {
                return sce;
            }
        }

        public string MyIP
        {
            get
            {
                return NetworkInfo.DefaultIP;
            }
        }

        internal void StartEventClient()
        {
            sce = new SendEventClient(host_ip, NetworkInfo.EventPort);
        }

        public void Start(string host_ip)
        {
            this.host_ip = host_ip;
            imgServer = new ImageServer(MyIP, NetworkInfo.ImgPort);
            imgServer.RecvedImage += imgServer_RecvedImage;
            SetupClient.Setup(host_ip, NetworkInfo.SetupPort);

        }

        private void imgServer_RecvedImage(object sender, RecvImageEventArgs e)
        {
            if (RecvedImage != null)
            {
                RecvedImage(this, e);
            }
        }

        public void Stop()
        {
            if(imgServer != null)
            {
                imgServer.Close();
                imgServer = null;
            }
        }

    }
}
