using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 원격제어_프로그램
{

    [Flags]
    public enum KeyFlag
    {
        KE_DOWN = 0, KE__EXTENDEDKEY = 1, KE_UP = 2
    }

    [Flags]
    public enum MouseFlag
    {
        ME_MOVE = 1, ME_LEFTDOWN = 2, ME_LEFTUP = 4, ME_RIGHTDOWN = 8,
        ME_RIGHTUP = 0x10, ME_MIDDLEDOWN = 0x20, ME_MIDDLEUP = 0x40, ME_WHEEL = 0x800,
        ME_ABSOULUTE = 8000
    }

    public static class WrapNative
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte vk, byte scan, int flags, int extra);

        [DllImport("user32.dll")]
        static extern void mouse_event(byte vk, int dx, int dy, int buttons, int extra);

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point point);

        [DllImport("user32.dll")]
        static extern int SetCursorPos(int x, int y);

        public static void KeyDown(int keycode)
        {
            keybd_event((byte)keycode, 0, (int)KeyFlag.KE_DOWN, 0);
        }

        public static void KeyUp(int keycode)
        {
            keybd_event((byte)keycode, 0, (int)KeyFlag.KE_UP, 0);
        }

        public static void Move(int x, int y)
        {
            SetCursorPos(x, y);
        }

        //사용자 편의를 위해 Point 매개변수를 가진 함수도 생성
        public static void Move(Point pt)
        {
            SetCursorPos(pt.X, pt.Y);
        }

        public static void LeftDown()
        {
            mouse_event((int)MouseFlag.ME_LEFTDOWN, 0, 0, 0, 0);
        }

        public static void LeftUp()
        {
            mouse_event((int)MouseFlag.ME_LEFTUP, 0, 0, 0, 0);
        }
    }
}
