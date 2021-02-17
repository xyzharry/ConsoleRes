//Farming tool project for the browser game "Grepolis".. only viable for personal use.

using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace ConsoleRes
{
    //import mouse hook
    class EntryPoint
    {
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        //mouse event variables
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        /* Replace current method with a function eventually..
        public void Clicker(int x, int y)
        {
            //Overview
            x = 205; y = 83;
            SetCursorPos(x, y);
            Thread.Sleep(1000);

            //Enter FV's
            x = 258; y = 388;
            SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);

            //Select All
            x = 796; y = 350;
            SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);

            //Collect
            x = 1226; y = 747;
            SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);

            //Are you sure? (yes)
            x = 895; y = 604;
            SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);

        }
        */
        static void Main()
        {
            //Command loop
            bool active = true;
            //Declare integers for mouse coordinates
            int x; int y;

            while (active == true)
            {
                Console.Title = "MakeSendRes v0.1";
                Console.WriteLine("Type 'run' to start");

                string answer = Console.ReadLine();
                if (answer == "run")
                {
                    Thread.Sleep(1500);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Farm Running");
                    //Overview
                    x = 205; y = 83;
                    SetCursorPos(x, y);
                    Thread.Sleep(1000);

                    //Enter FV's
                    x = 258; y = 388;
                    SetCursorPos(x, y);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
                    Thread.Sleep(1500);

                    //Select All
                    x = 796; y = 350;
                    SetCursorPos(x, y);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
                    Thread.Sleep(1500);

                    //Collect
                    x = 1226; y = 747;
                    SetCursorPos(x, y);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
                    Thread.Sleep(1500);

                    //Are you sure? (yes)
                    x = 895; y = 604;
                    SetCursorPos(x, y);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
                    Thread.Sleep(1500);
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.White;


                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Unknown Command");
                    Thread.Sleep(1500);
                    Console.Clear();
                }
            }
            Console.ReadLine();
        }
    }
}
