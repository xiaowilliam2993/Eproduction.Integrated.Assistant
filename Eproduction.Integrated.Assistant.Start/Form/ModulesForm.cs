using Eproduction.Integrated.Assistant.Start.Control;
using Eproduction.Integrated.Assistant.Start.Core;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Start {
    public partial class ModulesForm : Form {
        private EpIAContext _context = null;
        public EpIAContext Context { get => _context; }
        public ModulesForm(EpIAContext context) {
            InitializeComponent();

            _context = context;

            var logoControl = new LogoControl();
            logoControl.Name = "LogoControl";
            logoControl.Size = new Size(177, 49);
            logoControl.Location = new Point(24, 22);
            logoControl.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Controls.Add(logoControl);
        }

        private void ModulesForm_Load(object sender, EventArgs e) {
            int y_point = 0;
            foreach (var module in Context.Modules) {
                var moduleControl = new ModuleControl(module);
                moduleControl.Location = new Point(0, y_point);
                pnlModuleContainer.Controls.Add(moduleControl);
                y_point += moduleControl.Height;
            }
        }

        private void ModulesForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
