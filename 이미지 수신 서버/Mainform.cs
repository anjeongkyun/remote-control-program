using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 원격제어_프로그램;

namespace 이미지_수신_서버
{
    public partial class Mainform : Form
    {
        ImageServer ims = null;
        int cnt = 0;
        RecvEventServer res = null;

        static string DefaultIP
        {
            get{ return "127.0.0.1"; }
        }


        public Mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ims = new ImageServer(DefaultIP, 10200);
            ims.RecvedImage += Ims_ReceivedImage;
            res = new RecvEventServer(DefaultIP, 10300);
            res.RecvedKMEvent += Res_RecvedKMEvent;
        }

        private void Res_RecvedKMEvent(object sender, RecvKMEEventArgs e)
        {
            string s = e.MT.ToString();
            switch (e.MT)
            {
                case MsgType.MT_KDOWN:
                case MsgType.MT_KEYUP:
                    s += "" + e.Key.ToString();
                    break;

                case MsgType.MT_M_MOVE:
                    s += "" + e.Now.X.ToString() + "," + e.Now.Y.ToString();
                    break;

                default:
                    break;
            }

            listbox_event.Items.Add(s);
            listbox_event.SelectedIndex = listbox_event.Items.Count - 1;
        }

        private void Ims_ReceivedImage(object sender, RecvImageEventArgs e)
        {
            cnt++;
            e.Image.Save(string.Format("{0}.bmp", cnt));
            listbox_imgsendcnt.Items.Add(cnt);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_imgsendcnt.SelectedIndex == -1)
                return;

            int i_cnt = (int)listbox_imgsendcnt.SelectedItem;
            pb_receiveimg.ImageLocation = string.Format("{0}.bmp", i_cnt);

        }
    }
}
