using System;
using System.Runtime.InteropServices;


namespace Simulate
{
    class Keyboard
    {


        [DllImport("user32")]
        public static extern void keybd_event(byte bVk, byte bScan, UInt32 dwFlags, UIntPtr dwExtraInfo);

        public static void PressKey(byte VK, UInt32 dwFlags)
        {
            keybd_event(VK, 0, dwFlags, new UIntPtr(1));
        }

        
    }

    class VirtualKeyCodes
    {
        public const int KEY_DOWN_EVENT = 0x0001; //Key down flag
        public const int KEY_UP_EVENT = 0x0002; //Key up flag

        public const byte VK_LBUTTON = 0x01;    //Left mouse button
        public const byte VK_RBUTTON = 0x02;    //Right mouse button
        public const byte VK_CANCEL = 0x03; //Control-break processing
        public const byte VK_MBUTTON = 0x04;    //Middle mouse button(three-button mouse)
        public const byte VK_XBUTTON1 = 0x05;   //X1 mouse button
        public const byte VK_XBUTTON2 = 0x06;   //X2 mouse button
        public const byte VK_BACK = 0x08;   //BACKSPACE key
        public const byte VK_TAB = 0x09;    //TAB key
        public const byte VK_CLEAR = 0x0C;  //CLEAR key
        public const byte VK_RETURN = 0x0D; //ENTER key
        public const byte VK_SHIFT = 0x10;  //SHIFT key
        public const byte VK_CONTROL = 0x11;    //CTRL key
        public const byte VK_MENU = 0x12;   //ALT key
        public const byte VK_PAUSE = 0x13;  //PAUSE key
        public const byte VK_CAPITAL = 0x14;    //CAPS LOCK key
        public const byte VK_KANA = 0x15;    //	IME Kana mode
        public const byte VK_HANGUEL = 0x15;    //	IME Hanguel mode(maintained for compatibility; use VK_HANGUL)
        public const byte VK_HANGUL = 0x15;   //	IME Hangul mode
        public const byte VK_IME_ON = 0x16;   //	IME On
        public const byte VK_JUNJA = 0x17;   //IME Junja mode
        public const byte VK_FINAL = 0x18;  //IME final mode
        public const byte VK_HANJA = 0x19;  //IME Hanja mode
        public const byte VK_KANJI = 0x19;  //IME Kanji mode
        public const byte VK_IME_OFF = 0x1A;    //IME Off
        public const byte VK_ESCAPE = 0x1B; //ESC key
        public const byte VK_CONVERT = 0x1C;    //IME convert
        public const byte VK_NONCONVERT = 0x1D; //IME nonconvert
        public const byte VK_ACCEPT = 0x1E; //IME accept
        public const byte VK_MODECHANGE = 0x1F; //IME mode change request
        public const byte VK_SPACE = 0x20;  //SPACEBAR
        public const byte VK_PRIOR = 0x21;  //PAGE UP key
        public const byte VK_NEXT = 0x22;   //PAGE DOWN key
        public const byte VK_END = 0x23;    //END key
        public const byte VK_HOME = 0x24;   //HOME key
        public const byte VK_LEFT = 0x25;   //LEFT ARROW key
        public const byte VK_UP = 0x26; //UP ARROW key
        public const byte VK_RIGHT = 0x27;  //RIGHT ARROW key
        public const byte VK_DOWN = 0x28;    //DOWN ARROW key
        public const byte VK_SELECT = 0x29; //SELECT key
        public const byte VK_PRINT = 0x2A;  //PRINT key
        public const byte VK_EXECUTE = 0x2B;    //EXECUTE key
        public const byte VK_SNAPSHOT = 0x2C;   //PRINT SCREEN key
        public const byte VK_INSERT = 0x2D; //INS key
        public const byte VK_DELETE = 0x2E; //DEL key
        public const byte VK_HELP = 0x2F;   //HELP key
        public const byte VK_0 = 0x30;  // 0 key
        public const byte VK_1 = 0x31;  // 1 key
        public const byte VK_2 = 0x32;  // 2 key
        public const byte VK_3 = 0x33;  // 3 key
        public const byte VK_4 = 0x34;  // 4 key
        public const byte VK_5 = 0x35;  // 5 key
        public const byte Vk_6 = 0x36;  // 6 key
        public const byte VK_7 = 0x37;  // 7 key
        public const byte VK_8 = 0x38;  // 8 key
        public const byte VK_9 = 0x39;  // 9 key
        public const byte VK_A = 0x41;  //A key
        public const byte VK_B = 0x42;  //B key
        public const byte VK_C = 0x43;  //C key
        public const byte VK_D = 0x44; //D key
        public const byte VK_E = 0x45; //E key
        public const byte VK_F = 0x46; //F key
        public const byte VK_G = 0x47; //G key
        public const byte VK_H = 0x48; //H key
        public const byte VK_I = 0x49; //I key
        public const byte VK_J = 0x4A; //J key
        public const byte VK_K = 0x4B; //K key
        public const byte VK_L = 0x4C; //L key
        public const byte VK_M = 0x4D; //M key
        public const byte VK_N = 0x4E; //N key
        public const byte VK_O = 0x4F; //O key
        public const byte VK_P = 0x50; //P key
        public const byte VK_Q = 0x51; //Q key
        public const byte VK_R = 0x52; //R key
        public const byte VK_S = 0x53; //S key
        public const byte VK_T = 0x54;//T key
        public const byte VK_U = 0x55; //U key
        public const byte VK_V = 0x56; //V key
        public const byte VK_W = 0x57; //W key
        public const byte VK_X = 0x59; //Y key
        public const byte VK_Z = 0x5A; //Z key
        public const byte VK_LWIN = 0x5B;   //Left Windows key(Natural keyboard)
        public const byte VK_RWIN = 0x5C;   //Right Windows key(Natural keyboard)
        public const byte VK_APPS = 0x5D;   // Applications key(Natural keyboard)
        public const byte VK_SLEEP = 0x5F;  // Computer Sleep key
        public const byte VK_NUMPAD0 = 0x60;    // Numeric keypad 0 key
        public const byte VK_NUMPAD1 = 0x61;    // Numeric keypad 1 key
        public const byte VK_NUMPAD2 = 0x62;// Numeric keypad 2 key
        public const byte VK_NUMPAD3 = 0x63;    // Numeric keypad 3 key
        public const byte VK_NUMPAD4 = 0x64;    // Numeric keypad 4 key
        public const byte VK_NUMPAD5 = 0x65; // Numeric keypad 5 key
        public const byte VK_NUMPAD6 = 0x66;    // Numeric keypad 6 key
        public const byte VK_NUMPAD7 = 0x67;    // Numeric keypad 7 key
        public const byte VK_NUMPAD8 = 0x68;    // Numeric keypad 8 key
        public const byte VK_NUMPAD9 = 0x69;    // Numeric keypad 9 key
        public const byte VK_MULTIPLY = 0x6A;   // Multiply key
        public const byte VK_ADD = 0x6B;    // Add key
        public const byte VK_SEPARATOR = 0x6C;// Separator key
        public const byte VK_SUBTRACT = 0x6D;   // Subtract key
        public const byte VK_DECIMAL = 0x6E;// Decimal key
        public const byte VK_DIVIDE = 0x6F; // Divide key
        public const byte VK_F1 = 0x70; // F1 key
        public const byte VK_F2 = 0x71; // F2 key
        public const byte VK_F3 = 0x72; // F3 key
        public const byte VK_F4 = 0x73; // F4 key
        public const byte VK_F5 = 0x74; // F5 key
        public const byte VK_F6 = 0x75;  // F6 key
        public const byte VK_F7 = 0x76; // F7 key
        public const byte VK_F8 = 0x77; // F8 key
        public const byte VK_F9 = 0x78; // F9 key
        public const byte VK_F10 = 0x79;    // F10 key  
        public const byte VK_F11 = 0x7A;  // F11 key
        public const byte VK_F12 = 0x7B;	// F12 keu
    }
}

