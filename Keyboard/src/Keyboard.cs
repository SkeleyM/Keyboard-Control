using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace Simulate
{
    class Keyboard
    {
        [DllImport("user32")]
        public static extern void keybd_event(byte bVk, byte bScan, UInt32 dwFlags, UIntPtr dwExtraInfo);

        [DllImport("user32")]
        public static extern bool GetAsyncKeyState(int vKey);

        [DllImport("user32")]
        public static extern bool BlockInput(bool fBlockIt);


        // PressKey is just keybd_event however its easier to use
        public static void PressKey(byte VK, byte dwFlags)
        {
            keybd_event(VK, 0, VirtualKeyCode.KEY_UP_EVENT, new UIntPtr(1));
        }
        public static void PressKeyDown(byte VK)
        {
            PressKey(VK, VirtualKeyCode.KEY_DOWN_EVENT);
        }
        public static void PressKeyUp(byte VK)
        {
            PressKey(VK, VirtualKeyCode.KEY_UP_EVENT);
        }

        public static void Write(string str, int interval = 0)
        {   
            // makes them lowercase so that all the characters match with the dictionary in GetKeyCode()
            char[] letters = str.ToLower().ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                byte keyCode = VirtualKeyCode.GetKeyCode(letters[i]);
                PressKey(keyCode, VirtualKeyCode.KEY_DOWN_EVENT);
                System.Threading.Thread.Sleep(interval);
            }           
        }     
    }
}

