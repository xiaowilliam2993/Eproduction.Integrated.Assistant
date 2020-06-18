using Eproduction.Integrated.Assistant.Start.Core;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Start {
    public partial class ImportConfigurationForm : Form {
        public ConfigurationContext _context = null;
        public ConfigurationContext Context {
            get {
                if (_context == null) {
                    _context = new ConfigurationContext();
                }
                return _context;
            }
            private set => _context = value;
    }
        public string SelectedPath { get; set; }
        public ImportConfigurationForm() {
            InitializeComponent();

            _context = new ConfigurationContext();

            Func<string, string> ChooseFolderPath = (string _) => {
                string selectedPath = string.Empty;
                using (var browserDialog = new FolderBrowserDialog()) {
                    browserDialog.RootFolder = Environment.SpecialFolder.Desktop;
                    browserDialog.Description = _;
                    if (!string.IsNullOrEmpty(SelectedPath)) {
                        browserDialog.SelectedPath = SelectedPath;
                    }
                    if (browserDialog.ShowDialog() == DialogResult.OK) {
                        selectedPath = browserDialog.SelectedPath;
                        SelectedPath = selectedPath;
                    }
                }
                return selectedPath;
            };
            
            //
            // lnkOutputPath
            //
            lnkSourceEnvironmentPath.Click += (o, v) => {
                if (!string.IsNullOrEmpty(Context.SourceEnvironmentPath) && Directory.Exists(Context.SourceEnvironmentPath)) {
                    Process.Start(Context.SourceEnvironmentPath);
                }
            };
            //
            // lnkSelectSourceEnvironmentPath
            //
            lnkSelectSourceEnvironmentPath.Click += (o, v) => {
                string selectedPath = ChooseFolderPath("选择来源环境路径");
                if (!string.IsNullOrEmpty(selectedPath)) {
                    tboxSourceEnvironmentPath.Text = selectedPath;
                }
            };
            //
            // tboxSourceEnvironmentPath
            //
            tboxSourceEnvironmentPath.TextChanged += (o, v) => {
                var owner = (TextBox)o;
                var text = owner.Text;
                string message = string.Empty;
                if (string.IsNullOrEmpty(text)) {
                    message = "[来源环境路径不可空白]";
                } else {
                    if (!Directory.Exists(text)) {
                        message = "[来源环境路径无效或不存在]";
                    } else {
                        message = string.Empty;
                    }
                }
                ErrorProvider.SetError(owner, message);
            };
        }

        private void ImportConfigurationForm_Load(object sender, EventArgs e) {
            BindingSource.DataSource = Context;

            tboxSourceEnvironmentPath.DataBindings.Add(new Binding("Text", BindingSource, "SourceEnvironmentPath", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxIncludeAccountSetsConfiguration_dcxml.DataBindings.Add(new Binding("Checked", BindingSource, "IncludeAccountSetsConfiguration_dcxml", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxIncludeAutoRunClient_dcxml.DataBindings.Add(new Binding("Checked", BindingSource, "IncludeAutoRunClient_dcxml", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxIncludeDefault_dcc.DataBindings.Add(new Binding("Checked", BindingSource, "IncludeDefault_dcc", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxIncludeUpdate_config.DataBindings.Add(new Binding("Checked", BindingSource, "IncludeUpdate_config", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxIncludeWeb_config.DataBindings.Add(new Binding("Checked", BindingSource, "IncludeWeb_config", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxIncludeBusinessPackage_dcxml.DataBindings.Add(new Binding("Checked", BindingSource, "IncludeBusinessPackage_dxml", false, DataSourceUpdateMode.OnPropertyChanged));



        }

        private void ImportConfigurationForm_KeyDown(object sender, KeyEventArgs e) {
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
            //导入校验逻辑
            Func<bool> Validator = () => {
                bool successfully = true;
                string message = string.Empty;

                if (string.IsNullOrEmpty(Context.SourceEnvironmentPath)) {
                    message = "[来源环境路径不可空白]";
                    successfully = false;
                } else {
                    if (!Directory.Exists(Context.SourceEnvironmentPath)) {
                        message = "[来源环境路径无效或不存在]";
                        successfully = false;
                    } else {
                        message = string.Empty;
                    }
                }
                ErrorProvider.SetError(tboxSourceEnvironmentPath, message);

                if (!Context.IncludeAccountSetsConfiguration_dcxml && 
                    !Context.IncludeAutoRunClient_dcxml &&
                    !Context.IncludeDefault_dcc &&
                    !Context.IncludeUpdate_config && 
                    !Context.IncludeWeb_config &&
                    !Context.IncludeBusinessPackage_dxml) {
                    MessageBox.Show("导入目标请至少选择一项", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    successfully = false;
                }

                return successfully;
            };

            if (Validator()) {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
