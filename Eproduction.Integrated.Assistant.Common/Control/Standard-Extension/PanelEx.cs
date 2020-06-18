using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Common.Control {
    public partial class PanelEx : Panel {
        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hwnd);
        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);
        private Color _borderColor = Color.Black;
        private int _borderWidth = 1;

        [Description("边框颜色")]
        [Category("Appearance")]
        public Color BorderColor {
            get {
                return _borderColor;
            }
            set {
                _borderColor = value;
                Invalidate();
            }
        }
        [Description("边框宽度")]
        [Category("Appearance")]
        public int BorderWidth {
            get {
                return _borderWidth;
            }
            set {
                _borderWidth = value;
                Invalidate();
            }
        }
        public PanelEx() {
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, false);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Paint += new PaintEventHandler(PanelEx_Paint);
        }
        private void PanelEx_Paint(object sender, PaintEventArgs e) {
            if (BorderStyle == BorderStyle.FixedSingle) {
                IntPtr hDC = GetWindowDC(Handle);
                Graphics g = Graphics.FromHdc(hDC);
                ControlPaint.DrawBorder(g, new Rectangle(0, 0, Width, Height),
                    _borderColor, _borderWidth, ButtonBorderStyle.Solid,
                    _borderColor, _borderWidth, ButtonBorderStyle.Solid,
                    _borderColor, _borderWidth, ButtonBorderStyle.Solid,
                    _borderColor, _borderWidth, ButtonBorderStyle.Solid);
                g.Dispose();
                ReleaseDC(Handle, hDC);
            }
        }
    }
}
