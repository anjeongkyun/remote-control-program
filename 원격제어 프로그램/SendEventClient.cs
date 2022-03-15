using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 원격제어_프로그램
{
    public enum MsgType
    {
        MT_KDOWN = 1, MT_KEYUP, 
        MT_M_LEFTDOWN, MT_M_LEFTUP, MT_M_RIGHTDOWN, MT_M_RIGHTUP,
        MT_M_MIDDLEDOWN, MT_M_MIDDLEUP, MT_M_MOVE,
    }

    public class SendEventClient
    {
        IPEndPoint ep = null;
        Socket sock = null;
        public SendEventClient(string ip, int port)
        {
            ep = new IPEndPoint(IPAddress.Parse(ip), port);
        }



        private void SendData(byte[] data)
        {
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(ep);
            sock.Send(data);
            sock.Close();
        }

        public void SendKeyDown(int key)
        {
            byte[] data = new byte[9];
            data[0] = (byte)MsgType.MT_KDOWN;
            Array.Copy(BitConverter.GetBytes(key), 0, data, 1, 4);
            SendData(data);
        }

        public void SendKeyUp(int key)
        {
            byte[] data = new byte[9];
            data[0] = (byte)MsgType.MT_KEYUP;
            Array.Copy(BitConverter.GetBytes(key), 0, data, 1, 4);
            SendData(data);
        }

        public void SendMouseDown(MouseButtons mouseButtons)        
        {
            byte[] data = new byte[9];

            switch (mouseButtons)
            {
                case MouseButtons.Left:
                    data[0] = (byte)MsgType.MT_M_LEFTDOWN;
                    break;
                case MouseButtons.Right:
                    data[0] = (byte)MsgType.MT_M_RIGHTDOWN;
                    break;
                case MouseButtons.Middle:
                    data[0] = (byte)MsgType.MT_M_MIDDLEDOWN;
                    break;
                default:
                    break;
            }
            SendData(data);
        }

        public void SendMouseUp(MouseButtons mouseButtons)
        {
            byte[] data = new byte[9];

            switch (mouseButtons)
            {
                case MouseButtons.Left:
                    data[0] = (byte)MsgType.MT_M_LEFTUP;
                    break;
                case MouseButtons.Right:
                    data[0] = (byte)MsgType.MT_M_RIGHTUP;
                    break;
                case MouseButtons.Middle:
                    data[0] = (byte)MsgType.MT_M_MIDDLEUP;
                    break;
                default:
                    break;
            }
            SendData(data);
        }


        public void SendMouseMove(int x, int y)
        {
            byte[] data = new byte[9];
            data[0] = (byte)MsgType.MT_M_MOVE;
            Array.Copy(BitConverter.GetBytes(x), 0, data, 1, 4);
            Array.Copy(BitConverter.GetBytes(y), 0, data, 5, 4); // ? 왜 5에서 4인지?
            SendData(data);
        }
    }
}
