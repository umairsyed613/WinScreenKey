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

        private static readonly List<Keys> SpecialKeys = new List<Keys>
                                                             {
                                                                 Keys.Control, Keys.ControlKey, Keys.LControlKey, Keys.RControlKey,
                                                                 Keys.Alt, Keys.LMenu, Keys.RMenu, Keys.Shift, Keys.ShiftKey, Keys.LShiftKey, Keys.RShiftKey,
                                                                 Keys.Escape, Keys.End, Keys.Delete, Keys.Insert, Keys.Home
                                                             };

        public KeyboardListener()
        {
            Hook.GlobalEvents().KeyPress += OnKeyPress;
            Hook.GlobalEvents().KeyDown += KeyboardListener_KeyDown;
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Escape)
            {
                return;
            }

            OnKeyReceived?.Invoke(e);
        }

        private void KeyboardListener_KeyDown(object sender, KeyEventArgs e)
        {
            if (SpecialKeys.Contains(e.KeyData))
            {
                OnSpecialKeyReceived?.Invoke(e);
            }
        }
    }
}
