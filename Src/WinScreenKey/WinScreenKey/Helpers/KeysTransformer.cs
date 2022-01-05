using System;
using System.Windows.Forms;

namespace WinScreenKey.Helpers
{
    public static class KeysTransformer
    {
        public static string GetSpecialKeyAbr(Keys key)
        {
            switch (key)
            {
                case Keys.Shift:
                case Keys.ShiftKey:
                case Keys.LShiftKey:
                case Keys.RShiftKey:
                    return " Shift ";

                case Keys.Control:
                case Keys.ControlKey:
                case Keys.LControlKey:
                case Keys.RControlKey:
                    return " Ctrl ";

                case Keys.Alt:
                case Keys.LMenu:
                case Keys.RMenu:
                    return " Alt ";
                case Keys.Escape:
                    return " Esc ";
                case Keys.Delete:
                    return " Del ";
                case Keys.Insert:
                    return " Ins ";
                case Keys.Home:
                    return " Home ";
                case Keys.End:
                    return " End ";

                default:
                    throw new ArgumentOutOfRangeException(nameof(key), key, null);
            }
        }
    }
}
