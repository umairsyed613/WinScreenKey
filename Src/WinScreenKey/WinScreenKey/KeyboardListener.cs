using System.Collections.Generic;
using System.Windows.Forms;

using Gma.System.MouseKeyHook;

namespace WinScreenKey
{
    public class KeyboardListener
    {
        public delegate void KeyHandler(KeyPressEventArgs keyEventArgs);

        public event KeyHandler OnKeyReceived;

        public delegate void SpecialKeyHandler(KeyEventArgs keyEventArgs);

        public event SpecialKeyHandler OnSpecialKeyReceived;

        private static readonly List<Keys> specialKeys = new List<Keys>
                                                             {
                                                                 Keys.Control, Keys.ControlKey, Keys.LControlKey, Keys.RControlKey,
                                                                 Keys.Alt, Keys.LMenu, Keys.RMenu, Keys.Shift, Keys.ShiftKey, Keys.LShiftKey, Keys.RShiftKey
                                                             };

        public KeyboardListener()
        {
            Hook.GlobalEvents().KeyPress += (sender, e) => OnKeyReceived?.Invoke(e);
            Hook.GlobalEvents().KeyDown += KeyboardListener_KeyDown;
        }

        private void KeyboardListener_KeyDown(object sender, KeyEventArgs e)
        {

            if (specialKeys.Contains(e.KeyData))
            {
                OnSpecialKeyReceived?.Invoke(e);
            }
        }
    }
}
