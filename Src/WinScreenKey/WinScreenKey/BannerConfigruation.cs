using System.Drawing;

namespace WinScreenKey
{
    public class BannerConfigruation
    {
        public int TextClearTimeOut { get; set; } = 2000;

        public int BannerCloseTimeOut { get; set; } = 7000;

        public int Height { get; set; } = 70;

        public Color BackgroundColor { get; set; } = Color.Black;

        public Color ForegroundColor { get; set; } = Color.White;

        public Font Font { get; set; }
    }
}
