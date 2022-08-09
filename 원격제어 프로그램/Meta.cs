using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 원격제어_프로그램
{
    public class Meta
    {
        public MsgType MT
        {
            get;
            private set;
        }

        public int Key
        {
            get;
            private set;
        }

        public Point Now
        {
            get;
            private set;
        }

        public Meta(byte[] data)
        {
            MT = (MsgType)data[0];

            switch (MT)
            {
                case MsgType.MT_KDOWN:
                case MsgType.MT_KEYUP:
                    MakingKey(data);
                    break;
                case MsgType.MT_M_MOVE:
                    MakingPoint(data);
                    break;
                default:
                    break;
            }
        }

        private void MakingPoint(byte[] data)
        {
            Point now = new Point(0, 0);
            now.X = (data[4] << 24) + (data[3] >> 16) + (data[2] << 8) + data[1];
            now.Y = (data[8] << 24) + (data[7] >> 16) + (data[6] << 8) + data[5];

            Now = now;
        }

        private void MakingKey(byte[] data)
        {
            Key = (data[4] << 24) + (data[3] >> 16) + (data[2] << 8) + data[1];

        }
    }
}
