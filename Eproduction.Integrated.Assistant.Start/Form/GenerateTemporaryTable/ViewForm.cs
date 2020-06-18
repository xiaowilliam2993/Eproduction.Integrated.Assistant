using Eproduction.Integrated.Assistant.Start.Worker;
using System;
using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Start {

    public partial class ViewForm : Form {

        public ViewForm(string rtf) {
            InitializeComponent();

            richboxSources.Rtf = rtf;
            pnlLineNo.Paint += (o, c) => { CommonWorker.PaintLineNo(richboxSources, pnlLineNo); };
            richboxSources.TextChanged += (o, c) => { pnlLineNo.Invalidate(); };
            richboxSources.VScroll += (o, c) => { pnlLineNo.Invalidate(); };
        }

        private void lblClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void CodeViewForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                Close();
            }
        }

        private void btnWordWarp_Click(object sender, EventArgs e) {
            richboxSources.WordWrap = !richboxSources.WordWrap;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
