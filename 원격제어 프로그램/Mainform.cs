using MyDemoLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 원격제어_프로그램
{

    public partial class Mainform : Form
    {

        string serverIp;
        int serverPort;
        RemoteClientForm rcf = null;
        VirtualCursorForm vcf = null;

        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            rcf = new RemoteClientForm();
            vcf = new VirtualCursorForm();

            Text += ":" + NetworkInfo.DefaultIP;
            Remote.Singleton.RecvedRCInfo += Singleton_RecvedRCInfo;
        }

        delegate void Remote_Dele(object sender, RecvRCInfoEventArgs e);
        private void Singleton_RecvedRCInfo(object sender, RecvRCInfoEventArgs e)
        {
            if (this.InvokeRequired)
            {
                object[] objs = new object[2] { sender, e };
                this.Invoke(new Remote_Dele(Singleton_RecvedRCInfo), objs);
            }
            else
            {
                tbox_controller_ip.Text = e.IPAddressStr;
                serverIp = e.IPAddressStr;
                serverPort = e.Port;
                btn_ok.Enabled = true;
            }
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            if(tbox_ip.Text == NetworkInfo.DefaultIP)
            {
                MessageBox.Show("같은 호스트를 원격제어 할 수 없습니다.");
                tbox_ip.Text = string.Empty;
                return;
            }
            string host_ip = tbox_ip.Text;
            Rectangle rect = Remote.Singleton.Rect;
            Controller.Singleton.Start(host_ip);

            rcf.ClientSize = new Size(rect.Width - 40, rect.Height - 80);
            rcf.Show();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Hide();
            Remote.Singleton.RecvEventStart();
            timer_send_img.Start();
            vcf.Show();
        }


        private void noti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void Mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Remote.Singleton.Stop();
            Controller.Singleton.Stop();
            Application.Exit();
        }

        private void timer_send_img_Tick(object sender, EventArgs e)
        {
            Rectangle rect = Remote.Singleton.Rect;
            Bitmap bitmap = new Bitmap(rect.Width, rect.Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            Size size2 = new Size(rect.Width, rect.Height);
            graphics.CopyFromScreen(new Point(0, 0), new Point(0, 0), size2);
            graphics.Dispose();

            try
            {
                ImageClient ic = new ImageClient();
                ic.Connect(serverIp, NetworkInfo.ImgPort);
                ic.SendImageAsync(bitmap, null);
            }
            catch(Exception ex)
            {
                timer_send_img.Stop();
                MessageBox.Show("error : " + ex.Message);
                MessageBox.Show("클라이언트 또는 서버 문제 발생");
            }
        }
    }
}
