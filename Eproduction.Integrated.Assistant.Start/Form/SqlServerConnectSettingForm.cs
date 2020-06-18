using Eproduction.Integrated.Assistant.Common.Core;
using System;
using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Start {
    public partial class SqlServerConnectSettingForm : Form {
        public SqlServerDbContext SqlServerDbContext { get => SqlServerDbSelector.DataSource; }
        public SqlServerConnectSettingForm(string connectionString) {
            InitializeComponent();

            if (!string.IsNullOrEmpty(connectionString)) {
                SqlServerDbSelector.DataSource.Analyze(connectionString);
            }
        }

        private void SqlServerConnectSettingForm_KeyDown(object sender, KeyEventArgs e) {
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
