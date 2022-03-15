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

namespace 이미지_캡쳐_및_전송_클라이언트
{
    public partial class Mainform : Form
    {
        string ip = string.Empty;
        ImageClient ic = null;
        Bitmap bt = null;
        int width = -1;
        int height = -1;
        int left = -1;
        int right = -1;
        int top = -1;
        int bottom = -1;


        public Mainform()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ic = new ImageClient();
            tbar_left.Maximum = tbar_right.Maximum = Screen.PrimaryScreen.Bounds.Width;
            tbar_top.Maximum = tbar_bottom.Maximum = Screen.PrimaryScreen.Bounds.Height;
        }

        private void size_calculate()
        {
            left = tbar_left.Value;
            right = tbar_right.Value;

            if (left > right)
            {
                int temp = left;
                left = right;
                right = temp;
            }

            top = tbar_top.Value;
            bottom = tbar_bottom.Value;
            if (top > bottom)
            {
                int temp = top;
                top = bottom;
                bottom = temp;
            }

            width = right - left;
            height = bottom - top;

            if (width == 0 || height == 0)
                return;
        }

        private void fn_public_img_invalidate()
        {
            size_calculate();
            bitmap_copy();
            pb_captureimg.Image = bt;
            pb_captureimg.Invalidate();
        }
        private void bitmap_copy()
        {
            try
            {
                bt = new Bitmap(width, height);
                Graphics gr = Graphics.FromImage(bt);
                Size size = new Size(width, height);
                gr.CopyFromScreen(new Point(left, top), new Point(0, 0), size);
            }
            catch (Exception ex)
            {

            }
        }
        private void btn_ip_input_Click(object sender, EventArgs e)
        {
            ip = tbox_ip.Text;
        }

        private void btn_img_send_Click(object sender, EventArgs e)
        {
            if (ic == null)
                return;

            pb_captureimg.Image = null;

            size_calculate();
            bitmap_copy();

            ic.Connect(ip, 10200);

            ic.SendImage(bt);
            ic.Close();
            pb_captureimg.Image = bt;

        }

        #region 트랙바 스크롤 이벤트
        private void tbar_left_Scroll(object sender, EventArgs e)
        {
            fn_public_img_invalidate();
        }

        private void tbar_top_Scroll(object sender, EventArgs e)
        {
            fn_public_img_invalidate();

        }

        private void tbar_right_Scroll(object sender, EventArgs e)
        {
            fn_public_img_invalidate();

        }

        private void tbar_bottom_Scroll(object sender, EventArgs e)
        {
            fn_public_img_invalidate();

        }
        #endregion

        #region 텍스트 이벤트 모음
        private void richtbox_event_MouseDown(object sender, MouseEventArgs e)
        {
            if (ip == null)
                return;

            SendEventClient sec = new SendEventClient(ip, 10300);
            sec.SendMouseUp(e.Button);
        }

        private void richtbox_event_MouseMove(object sender, MouseEventArgs e)
        {
            if (ip == null)
                return;
            
            SendEventClient sec = new SendEventClient(ip, 10300);
            sec.SendMouseMove(e.X,e.Y);
        }

        private void richtbox_event_MouseUp(object sender, MouseEventArgs e)
        {
            if (ip == null)
                return;

            SendEventClient sec = new SendEventClient(ip, 10300);
            sec.SendMouseDown(e.Button);
        }

        private void richtbox_event_KeyDown(object sender, KeyEventArgs e)
        {
            if (ip == null)
                return;

            SendEventClient sec = new SendEventClient(ip, 10300);
            sec.SendKeyDown(e.KeyValue);
        }

        private void richtbox_event_KeyUp(object sender, KeyEventArgs e)
        {
            if (ip == null)
                return;

            SendEventClient sec = new SendEventClient(ip, 10300);
            sec.SendKeyUp(e.KeyValue);
        }
        #endregion
    }
}
