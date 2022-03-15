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
    public partial class RemoteClientForm : Form
    {
        bool check;
        Size size;

        SendEventClient EventSC
        {
            get
            {
                return Controller.Singleton.SencEventClient;
            }
        }

        public RemoteClientForm()
        {
            InitializeComponent();
        }

        private void RemoteClientForm_Load(object sender, EventArgs e)
        {
            Controller.Singleton.RecvedImage += Singleton_RecvedImage;
        }

        private void Singleton_RecvedImage(object sender, RecvImageEventArgs e)
        {
            if(check == false)
            {
                Controller.Singleton.StartEventClient();
                check = true;
                ClientSize = e.Image.Size;
            }
            pbox_remote.Image = e.Image;
        }

        private void RemoteClientForm_KeyUp(object sender, KeyEventArgs e)
        {
            if(check == true)
            {
                EventSC.SendKeyUp(e.KeyValue);
            }
        }

        private void RemoteClientForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (check == true)
            {
                EventSC.SendKeyDown(e.KeyValue);
            }
        }

        private void pbox_remote_MouseDown(object sender, MouseEventArgs e)
        {
            if (check == true)
            {
                Text = e.Location.ToString();
                EventSC.SendMouseDown(e.Button);
            }
        }
        private void pbox_remote_MouseUp(object sender, MouseEventArgs e)
        {
            if (check == true)
            {
                Text = e.Location.ToString();
                EventSC.SendMouseUp(e.Button);
            }
        }
        private void pbox_remote_MouseMove(object sender, MouseEventArgs e)
        {
            if (check == true)
            {
                Point pt = ConvertPoint(e.X, e.Y);
                Text = e.Location.ToString();
                EventSC.SendMouseMove(pt.X, pt.Y);
            }
        }

        private Point ConvertPoint(int x, int y)
        {
            int nx = ClientSize.Width * x / pbox_remote.Width;
            int ny = ClientSize.Height * x / pbox_remote.Height;

            return new Point(nx, ny);
        }
    }
}
