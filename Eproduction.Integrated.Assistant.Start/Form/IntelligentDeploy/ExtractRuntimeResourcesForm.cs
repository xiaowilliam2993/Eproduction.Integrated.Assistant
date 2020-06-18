using Eproduction.Integrated.Assistant.Start.Core;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Start {
    public partial class ExtractRuntimeResourcesForm : Form {
        private ExtractRuntimeResourcesContext _context = null;
        public ExtractRuntimeResourcesContext Context { get => _context; }
        public string SelectedPath { get; set; }
        public ExtractRuntimeResourcesForm(string typeKey) {
            InitializeComponent();

            _context = new ExtractRuntimeResourcesContext(typeKey);

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

            EventHandler RadioCheckedChangedHandler = (o, v) => {
                var owner = (RadioButton)o;
                var tag = owner.Tag;
                if (owner.Checked && tag != null) {
                    Context.DeployType = Convert.ToInt32(tag, CultureInfo.CurrentCulture);
                }
            };

            //
            // tboxTypeKey
            //
            tboxTypeKey.TextChanged += (o, v) => {
                var owner = (TextBox)o;
                var text = owner.Text;
                string message = string.Empty;
                if (string.IsNullOrEmpty(text)) {
                    message = "[TypeKey不可空白]";
                } else {
                    message = string.Empty;
                }
                ErrorProvider.SetError(owner, message);
            };
            //
            // lnkOutputPath
            //
            lnkOutputPath.Click += (o, v) => {
                if (!string.IsNullOrEmpty(Context.OutputPath) && Directory.Exists(Context.OutputPath)) {
                    Process.Start(Context.OutputPath);
                }
            };
            //
            // lnkSelectOutputPath
            //
            lnkSelectOutputPath.Click += (o, v) => {
                string selectedPath = ChooseFolderPath("选择输出路径");
                if (!string.IsNullOrEmpty(selectedPath)) {
                    tboxOutputPath.Text = selectedPath;
                }
            };
            //
            // tboxOutputPath
            //
            tboxOutputPath.TextChanged += (o, v) => {
                var owner = (TextBox)o;
                var text = owner.Text;
                string message = string.Empty;
                if (string.IsNullOrEmpty(text)) {
                    message = "[输出路径不可空白]";
                } else {
                    if (!Directory.Exists(text)) {
                        message = "[输出路径无效或不存在]";
                    } else {
                        message = string.Empty;
                    }
                }
                ErrorProvider.SetError(owner, message);
            };
            //
            // rdoBase
            //
            rdoBase.CheckedChanged += RadioCheckedChangedHandler;
            //
            // rdoIndustry
            //
            rdoIndustry.CheckedChanged += RadioCheckedChangedHandler;
            //
            // rdoCustomization
            //
            rdoCustomization.CheckedChanged += RadioCheckedChangedHandler;
        }

        private void ExtractRuntimeResourcesForm_Load(object sender, EventArgs e) {
            BindingSource.DataSource = Context;

            tboxTypeKey.DataBindings.Add(new Binding("Text", BindingSource, "TypeKey", false, DataSourceUpdateMode.OnPropertyChanged));
            tboxOutputPath.DataBindings.Add(new Binding("Text", BindingSource, "OutputPath", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxIncludeDllResources.DataBindings.Add(new Binding("Checked", BindingSource, "IncludeDllResources", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxIncludeConfigurationResources.DataBindings.Add(new Binding("Checked", BindingSource, "IncludeConfigurationResources", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxIncludeProgramInfoResources.DataBindings.Add(new Binding("Checked", BindingSource, "IncludeProgramInfoResources", false, DataSourceUpdateMode.OnPropertyChanged));

            switch (Context.DeployTarget) {
                case DeployTarget.Base:
                    rdoBase.Checked = true;
                    break;
                case DeployTarget.Industry:
                    rdoIndustry.Checked = true;
                    break;
                case DeployTarget.Customization:
                    rdoCustomization.Checked = true;
                    break;
            }
        }

        private void ExtractRuntimeResourcesForm_KeyDown(object sender, KeyEventArgs e) {
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
            //提取校验逻辑
            Func<bool> Validator = () => {
                bool successfully = true;
                string message = string.Empty;

                if (string.IsNullOrEmpty(Context.TypeKey)) {
                    message = "[TypeKey不可空白]";
                    successfully = false;
                } else {
                    message = string.Empty;
                }
                ErrorProvider.SetError(tboxTypeKey, message);

                if (string.IsNullOrEmpty(Context.OutputPath)) {
                    message = "[输出路径不可空白]";
                    successfully = false;
                } else {
                    try {
                        var outputDirectory = new DirectoryInfo(Context.OutputPath);
                        if (!outputDirectory.Exists) {
                            outputDirectory.Create();
                        }
                    } catch (Exception ex) {
                        successfully = false;
                        MessageBox.Show("创建输出路径失败，错误信息：" + ex.Message, "程序异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    message = string.Empty;
                }
                ErrorProvider.SetError(tboxOutputPath, message);

                if (successfully) {
                    if (!Context.IncludeDllResources && !Context.IncludeConfigurationResources && !Context.IncludeProgramInfoResources) {
                        successfully = false;
                        MessageBox.Show("提取目标请至少选择一项", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
