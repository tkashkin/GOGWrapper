using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace GOGWrapper.Utils
{
	public class WinAPI
    {
        public const int WM_COMMAND = 0x111;
        public const int WM_LBUTTONDOWN = 0x201;
        public const int WM_LBUTTONUP = 0x202;
        public const int WM_LBUTTONDBLCLK = 0x203;
        public const int WM_RBUTTONDOWN = 0x204;
        public const int WM_RBUTTONUP = 0x205;
        public const int WM_RBUTTONDBLCLK = 0x206;
        public const int WM_KEYDOWN = 0x100;
        public const int WM_KEYUP = 0x101;

		[DllImport("user32.dll")]
		public static extern IntPtr FindWindow(string strClassName, string strWindowName);

		[DllImport("user32.dll")]
		public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string strClassName, string strWindowName);
        
        [DllImport("user32.dll")]
        public static extern bool IsWindow(IntPtr hwnd);

        [DllImport("user32.dll")]
		public static extern Int32 SendMessage(IntPtr hWnd, Int32 Msg, Int32 wParam, [MarshalAs(UnmanagedType.LPStr)] string lParam);

		[DllImport("user32.dll")]
		public static extern Int32 SendMessage(IntPtr hWnd, Int32 Msg, Int32 wParam, Int32 lParam);

        public static IntPtr WaitForWindow(string className, string windowName)
        {
            IntPtr hwnd = (IntPtr) 0;
            while(!WinAPI.IsWindow(hwnd))
            {
                hwnd = WinAPI.FindWindow(className, windowName);
                Thread.Sleep(100);
            }
            return hwnd;
        }

        public static IntPtr WaitForChildWindow(IntPtr parent, string className, string windowName)
        {
            IntPtr hwnd = (IntPtr) 0;
            while (!WinAPI.IsWindow(hwnd))
            {
                hwnd = WinAPI.FindWindowEx(parent, (IntPtr) 0, className, windowName);
                Thread.Sleep(100);
            }
            return parent;
        }
        
        [DllImport("user32.dll")]
        static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

        [DllImport("user32.dll")]
        internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);
        
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        internal struct INPUT
        {
            public UInt32 Type;
            public MOUSEKEYBDHARDWAREINPUT Data;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct MOUSEKEYBDHARDWAREINPUT
        {
            [FieldOffset(0)]
            public MOUSEINPUT Mouse;
        }

        internal struct MOUSEINPUT
        {
            public Int32 X;
            public Int32 Y;
            public UInt32 MouseData;
            public UInt32 Flags;
            public UInt32 Time;
            public IntPtr ExtraInfo;
        }

        public static void Click(IntPtr wndHandle, Point clientPoint)
        {
            var oldPos = Cursor.Position;
            ClientToScreen(wndHandle, ref clientPoint);

            Cursor.Position = new Point(clientPoint.X, clientPoint.Y);
            var inputMouseDown = new INPUT();
            inputMouseDown.Type = 0;
            inputMouseDown.Data.Mouse.Flags = 0x0002;

            var inputMouseUp = new INPUT();
            inputMouseUp.Type = 0;
            inputMouseUp.Data.Mouse.Flags = 0x0004;

            var inputs = new INPUT[] { inputMouseDown, inputMouseUp };
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
            
            Cursor.Position = oldPos;
        }
    }
}
