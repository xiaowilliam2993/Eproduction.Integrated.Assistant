using System.Drawing;
using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Common.Control {
    public partial class ProgressBarEx : ProgressBar {
        public ProgressBarEx() {
            SetStyle(ControlStyles.UserPaint, true);
            BackColor = SystemColors.ControlLight;
            ForeColor = Color.FromArgb(15, 180, 148);
        }
        protected override void OnPaint(PaintEventArgs e) {
            SolidBrush brush = null;
            Rectangle bounds = new Rectangle(0, 0, Width, Height);
            e.Graphics.FillRectangle(new SolidBrush(BackColor), 1, 1, bounds.Width, bounds.Height);
            bounds.Width = ((int)(bounds.Width * (((double)Value) / ((double)Maximum))));
            brush = new SolidBrush(ForeColor);
            e.Graphics.FillRectangle(brush, 0, 0, bounds.Width, bounds.Height);
        }
    }
    public class Progress {
        public double Value { get; set; }
        public string Caption { get; set; }
    }
}
