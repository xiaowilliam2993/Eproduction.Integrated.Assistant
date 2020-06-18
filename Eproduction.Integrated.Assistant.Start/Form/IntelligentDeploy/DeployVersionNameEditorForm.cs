using Eproduction.Integrated.Assistant.Start.Core;
using Eproduction.Integrated.Assistant.Start.Worker;
using System;
using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Start {
    public partial class DeployVersionNameEditorForm : Form {
        /// <summary>
        /// 目标版本
        /// </summary>
        public DeployVersionContext Version { get; set; }
        public DeployVersionNameEditorForm(DeployVersionContext version) {
            InitializeComponent();

            Version = version;

            //
            // tboxVersionName
            //
            tboxVersionName.Text = Version.Name;
            tboxVersionName.TextChanged += (o, v) => {
                var sender = (TextBox)o;
                var versionName = sender.Text;
                string message = string.Empty;
                if (string.IsNullOrEmpty(versionName)) {
                    message = "[版本名称不可空白]";
                } else {
                    if (versionName.Length > 20) {
                        message = "[版本名称长度不可超过20个字符]";
                    } else if (IntelligentDeployWorker.IsExistsVersionName(Version, versionName)) {
                        message = "[版本名称已存在]";
                    }
                }
                ErrorProvider.SetError(sender, message);
            };
        }

        private void DeployVersionNameEditorForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void btnDone_Click(object sender, EventArgs e) {
            //校验逻辑
            Func<bool> Validator = () => {
                bool successfully = true;

                string versionName = tboxVersionName.Text;
                string message = string.Empty;
                if (string.IsNullOrEmpty(versionName)) {
                    message = "[版本名称不可空白]";
                    successfully = false;
                } else {
                    if (versionName.Length > 20) {
                        message = "[版本名称长度不可超过20个字符]";
                        successfully = false;
                    } else if (IntelligentDeployWorker.IsExistsVersionName(Version, versionName)) {
                        message = "[版本名称已存在]";
                        successfully = false;
                    }
                }
                ErrorProvider.SetError(tboxVersionName, message);

                return successfully;
            };

            if (Validator()) {
                var versionName = tboxVersionName.Text;
                var oldVersionName = Version.Name;
                Version.Name = versionName;
                IntelligentDeployWorker.SaveDeployVersion(Version, oldVersionName);

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
