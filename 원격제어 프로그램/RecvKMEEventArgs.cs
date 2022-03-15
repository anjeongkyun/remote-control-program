using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 원격제어_프로그램
{
    public delegate void RecvKMEEventHandler(object sender, RecvKMEEventArgs e);

    public class RecvKMEEventArgs : EventArgs
    { 
        public Meta Meta
        {
            get;
            private set;
        }

        public int Key
        {
            get
            {
                return Meta.Key;
            }
        }

        public Point Now
        {
            get
            {
                return Meta.Now;
            }
        }

        public MsgType MT
        {
            get
            {
                return Meta.MT;
            }
        }

        public RecvKMEEventArgs(Meta meta)
        {
            Meta = meta;
        }
    }
}
