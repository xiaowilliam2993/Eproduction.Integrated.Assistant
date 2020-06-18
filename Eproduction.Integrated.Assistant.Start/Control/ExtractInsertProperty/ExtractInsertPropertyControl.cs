using Eproduction.Integrated.Assistant.Start.Core;
using Eproduction.Integrated.Assistant.Start.Worker;
using System;
using System.Text;
using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Start.Control {
    public partial class ExtractInsertPropertyControl : UserControl {
        private EpIAContext _EpIAContext = null;
        public EpIAContext EpIAContext { get => _EpIAContext; }
        public ExtractInsertPropertyControl(EpIAContext context) {
            InitializeComponent();

            Dock = DockStyle.Fill;

            _EpIAContext = context;

            //
            // pnlSpecificationSourceLineNo
            //
            pnlSpecificationSourceLineNo.Paint += (o, v) => { CommonWorker.PaintLineNo(richboxSpecificationSource, (Panel)o); };
            //
            // richboxSpecificationSource
            //
            richboxSpecificationSource.TextChanged += (o, v) => { pnlSpecificationSourceLineNo.Invalidate(); };
            richboxSpecificationSource.VScroll += (o, v) => { pnlSpecificationSourceLineNo.Invalidate(); };
            //
            // pnlExtractLineNo
            //
            pnlExtractLineNo.Paint += (o, v) => { CommonWorker.PaintLineNo(richboxExtract, (Panel)o); };
            //
            // richboxExtract
            //
            richboxExtract.TextChanged += (o, v) => { pnlExtractLineNo.Invalidate(); };
            richboxExtract.VScroll += (o, v) => { pnlExtractLineNo.Invalidate(); };
        }

        private void btnExtract_Click(object sender, EventArgs e) {
            try {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine("new string[] { ");
                int index = 0;
                foreach (var line in richboxSpecificationSource.Lines) {
                    if (!string.IsNullOrEmpty(line)) {
                        index++;
                        string tempLine = line;
                        int positionLeft = tempLine.IndexOf(tboxLeftDelimiterChar.Text);
                        int positionRight = tempLine.IndexOf(tboxRightDelimiterChar.Text);
                        if (positionLeft < 0 || positionRight - (positionLeft + 1) < 0) continue;
                        string fieldName = tempLine.Substring(positionLeft + 1, positionRight - (positionLeft + 1)).Trim();
                        if (index == 1) {
                            builder.AppendLine("      \"" + fieldName + "\"");
                        } else {
                            builder.AppendLine("    , \"" + fieldName + "\"");
                        }
                    }
                }
                builder.AppendLine("}");
                richboxExtract.Text = builder.ToString();
            } catch (Exception ex) {
                MessageBox.Show($"提取INSERT属性失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
