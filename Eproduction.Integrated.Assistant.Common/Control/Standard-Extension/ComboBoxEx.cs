using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Common.Control {
    public class ComboBoxEx : ComboBox {

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        private bool _HotTrack = true;
        private Color _BorderColor = Color.Silver;
        private Color _HotColor = Color.FromArgb(0, 192, 192);
        private bool _IsMouseOver = false;

        [Category("行为")]
        [Description("获得或设置一个值，指示当前鼠标经过控件时控件边框是否发生变化。只在控件的BorderStyle为FixedString时有效")]
        [DefaultValue(true)]
        public bool HotTrack {
            get { return _HotTrack; }
            set {
                _HotTrack = value;
                Invalidate();
            }
        }
        [Category("外观")]
        [Description("获得或设置控件的边框颜色")]
        [DefaultValue(typeof(Color), "black")]
        public Color BorderColor {
            get { return _BorderColor; }
            set {
                _BorderColor = value;
                Invalidate();
            }
        }
        [Category("外观")]
        [Description("获得或设置当鼠标经过时控件的边框颜色。只在控件的BorderStyle为FixedSing时有效")]
        [DefaultValue(typeof(Color), "red")]
        public Color HotColor {
            get { return _HotColor; }
            set {
                _HotColor = value;
                Invalidate();
            }
        }

        public ComboBoxEx() : base() {
            DropDownStyle = ComboBoxStyle.DropDown;
        }
        protected override void OnMouseMove(MouseEventArgs e) {
            _IsMouseOver = true;
            if (_HotTrack) {
                Invalidate();
            }
            base.OnMouseMove(e);
        }
        protected override void OnMouseLeave(EventArgs e) {
            _IsMouseOver = false;
            if (_HotTrack) {
                Invalidate();
            }
            base.OnMouseLeave(e);
        }
        protected override void OnGotFocus(EventArgs e) {
            if (_HotTrack) {
                Invalidate();
            }
            base.OnGotFocus(e);
        }
        protected override void OnLostFocus(EventArgs e) {
            if (_HotTrack) {
                Invalidate();
            }
            base.OnLostFocus(e);
        }
        protected override void WndProc(ref Message m) {
            base.WndProc(ref m);
            try {
                if (m.Msg == 0xf || m.Msg == 0x133) {
                    IntPtr hDC = GetWindowDC(m.HWnd);
                    if (hDC.ToInt32() == 0)
                        return;
                    if (DropDownStyle == ComboBoxStyle.DropDown) {
                        Pen p = new Pen(_BorderColor, 1.5f);
                        if (HotTrack) {
                            if (Focused) {
                                p.Color = _HotColor;
                            }
                        } else {
                            if (_IsMouseOver) {
                                p.Color = _HotColor;
                            } else {
                                p.Color = _BorderColor;
                            }
                        }
                        Graphics g = Graphics.FromHdc(hDC);
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);
                        p.Dispose();
                    }
                    m.Result = IntPtr.Zero;
                    ReleaseDC(m.HWnd, hDC);
                }
            } catch { }
        }
    }
}
