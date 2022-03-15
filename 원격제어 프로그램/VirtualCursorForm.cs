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
    public partial class VirtualCursorForm : Form
    {
        public VirtualCursorForm()
        {
            InitializeComponent();
        }

        private void VirtualCursorForm_Load(object sender, EventArgs e)
        {
            Size = new Size(10, 10);
            Remote.Singleton.RecvedKMEvent += Singleton_RecvedKMEvent;
        }

        delegate void ChangeLocationDele(Point now, MsgType mt);
        private void ChangeLocation(Point now, MsgType mt)
        {
            if(mt == MsgType.MT_M_MOVE)
            {
                Location = new Point(now.X + 3, now.Y + 3);
            }
        }

        private void Singleton_RecvedKMEvent(object sender, RecvKMEEventArgs e)
        {
            //true : 폼을 생성했었던 스레드와 이 작업을 실행하는 스레드가 다르다.
            if (this.InvokeRequired)
            {
                object[] objs = new object[] { e.Now, e.MT };
                this.Invoke(new ChangeLocationDele(ChangeLocation), objs);
            }
            //크로스 스레드 에러가 발생하지 않으면 그대로 진행
            else
            {
                ChangeLocation(e.Now, e.MT);
            }
            
        }
    }
}
