using System.Drawing;
using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Start {

    public partial class AlterForm : Form {

        public AlterForm() {
            InitializeComponent();

            System.Drawing.Drawing2D.GraphicsPath formPath;
            formPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            int diameter = 10;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            System.Drawing.Drawing2D.GraphicsPath newPath = new System.Drawing.Drawing2D.GraphicsPath();
            newPath.AddArc(arcRect, 180, 90);
            arcRect.X = rect.Right - diameter;
            newPath.AddArc(arcRect, 270, 90);
            arcRect.Y = rect.Bottom - diameter;
            newPath.AddArc(arcRect, 0, 90);
            arcRect.X = rect.Left;
            newPath.AddArc(arcRect, 90, 90);
            newPath.CloseFigure();
            formPath = newPath;
            Region = new Region(formPath);
        }
    }
}
