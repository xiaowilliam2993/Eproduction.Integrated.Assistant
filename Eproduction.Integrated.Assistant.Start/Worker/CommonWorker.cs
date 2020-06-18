using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Start.Worker {
    public class CommonWorker {
        /// <summary>
        /// 绘制行号
        /// </summary>
        /// <param name="richbox"></param>
        /// <param name="component"></param>
        public static void PaintLineNo(TextBoxBase richbox, Panel component) {
            Point point = richbox.Location;
            int firstIndex = richbox.GetCharIndexFromPosition(point);
            int firstLine = richbox.GetLineFromCharIndex(firstIndex);
            Point firstPosition = richbox.GetPositionFromCharIndex(firstIndex);

            point.Y += richbox.Height;
            int lastIndex = richbox.GetCharIndexFromPosition(point);
            int lastLine = richbox.GetLineFromCharIndex(lastIndex);
            Point lastPosition = richbox.GetPositionFromCharIndex(lastIndex);

            Graphics g = component.CreateGraphics();
            Font font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            SolidBrush brush = new SolidBrush(Color.FromArgb(15, 180, 148));

            Rectangle rect = component.ClientRectangle;
            brush.Color = component.BackColor;
            g.FillRectangle(brush, 0, 0, component.ClientRectangle.Width, component.ClientRectangle.Height);
            brush.Color = Color.FromArgb(15, 180, 148);

            int lineSpace = 0;
            if (firstLine != lastLine) {
                lineSpace = (lastPosition.Y - firstPosition.Y) / (lastLine - firstLine);
            } else {
                lineSpace = (int)(Convert.ToInt32(richbox.Font.Size) * 1.6);
            }
            int brushX = component.ClientRectangle.Width - Convert.ToInt32(font.Size * 3.5);
            int brushY = lastPosition.Y + Convert.ToInt32(font.Size * 0.21f);
            int maxNum = 6;
            int charWidth = 7;
            int startWidth = 20;
            int noLength = 0;
            for (int i = lastLine; i >= 0; i--) {
                noLength = (i + 1).ToString().Length;
                if (noLength <= maxNum) {
                    g.DrawString((i + 1).ToString(), font, brush, brushX + (startWidth - (noLength - 1) * charWidth), brushY);
                } else {
                    g.DrawString((i + 1).ToString(), font, brush, brushX, brushY);
                }
                brushY -= lineSpace;
            }
            g.Dispose();
            font.Dispose();
            brush.Dispose();
        }
    }
}
