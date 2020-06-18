using Eproduction.Integrated.Assistant.Start.Core;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Start {
    public partial class AccountSetPerviewForm : Form {
        ConfigurationContext _configurationContext = null;
        public ConfigurationContext Context {
            get {
                if (_configurationContext == null) {
                    _configurationContext = new ConfigurationContext() ;
                }
                return _configurationContext;
            }
        }
        IEnumerable<string> ValidPaths { get; set; }
        IEnumerable<string> TargetPaths { get; set; }
        public AccountSetPerviewForm() {
            InitializeComponent();

            EventHandler CheckedChanged = (o, v) => {
                TargetPaths = GetTargets();
                btnOpenInDefaultPerview.Enabled = TargetPaths.Count() == 1;
                btnOpenInNotepad.Enabled = btnOpenInNotepadPlus.Enabled = TargetPaths.Count() > 0;
            };

            //
            // cboxIncludeAccountSetsConfiguration_dcxml
            //
            cboxIncludeAccountSetsConfiguration_dcxml.CheckedChanged += CheckedChanged;
            //
            // cboxIncludeAutoRunClient_dcxml
            //
            cboxIncludeAutoRunClient_dcxml.CheckedChanged += CheckedChanged;
            //
            // cboxIncludeDefault_dcc
            //
            cboxIncludeDefault_dcc.CheckedChanged += CheckedChanged;
            //
            // cboxIncludeUpdate_config
            //
            cboxIncludeUpdate_config.CheckedChanged += CheckedChanged;
            //
            // cboxIncludeWeb_config
            //
            cboxIncludeWeb_config.CheckedChanged += CheckedChanged;
            //
            // cboxIncludeBusinessPackage_dcxml
            //
            cboxIncludeBusinessPackage_dcxml.CheckedChanged += CheckedChanged;
        }

        private void AccountSetPerviewForm_Load(object sender, EventArgs e) {
            BindingSource.DataSource = Context;
            
            cboxIncludeAccountSetsConfiguration_dcxml.DataBindings.Add(new Binding("Checked", BindingSource, "IncludeAccountSetsConfiguration_dcxml", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxIncludeAutoRunClient_dcxml.DataBindings.Add(new Binding("Checked", BindingSource, "IncludeAutoRunClient_dcxml", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxIncludeDefault_dcc.DataBindings.Add(new Binding("Checked", BindingSource, "IncludeDefault_dcc", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxIncludeUpdate_config.DataBindings.Add(new Binding("Checked", BindingSource, "IncludeUpdate_config", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxIncludeWeb_config.DataBindings.Add(new Binding("Checked", BindingSource, "IncludeWeb_config", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxIncludeBusinessPackage_dcxml.DataBindings.Add(new Binding("Checked", BindingSource, "IncludeBusinessPackage_dxml", false, DataSourceUpdateMode.OnPropertyChanged));

            if (!File.Exists(Context.AccountSetsConfiguration_dcxml_Path)) {
                cboxIncludeAccountSetsConfiguration_dcxml.Enabled = false;
            } else {
                cboxIncludeAccountSetsConfiguration_dcxml.Checked = true;
            }
            if (!File.Exists(Context.AutoRunClient_dcxml_Path)) cboxIncludeAutoRunClient_dcxml.Enabled = false;
            if (!File.Exists(Context.Default_dcc_Path)) cboxIncludeDefault_dcc.Enabled = false;
            if (!File.Exists(Context.Update_config_Path)) cboxIncludeUpdate_config.Enabled = false;
            if (!File.Exists(Context.Web_config_Path)) cboxIncludeWeb_config.Enabled = false;
            if (!File.Exists(Context.BusinessPackage_dcxml_Path)) cboxIncludeBusinessPackage_dcxml.Enabled = false;

            IEnumerable<string> validPaths;
            if (Validator(out validPaths)) {
                ValidPaths = validPaths;
            } else {
                btnOpenInDefaultPerview.Enabled = btnOpenInNotepad.Enabled = btnOpenInNotepadPlus.Enabled = false;
            }
        }

        private void AccountSetPerviewForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Escape) {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void btnOpenInDefaultPerview_Click(object sender, EventArgs e) {
            var contents = File.ReadAllText(TargetPaths.First(), Encoding.UTF8);
            using (var viewForm = new DetailsViewForm(contents)) {
                viewForm.ShowDialog();
            }
            Close();
        }

        private void btnOpenInNotepad_Click(object sender, EventArgs e) {
            foreach (var path in TargetPaths) {
                Process.Start("notepad.exe", path);
            }
            Close();
        }

        private void btnOpenInNotepadPlus_Click(object sender, EventArgs e) {
            var registryPath64 = "SOFTWARE\\" + (Environment.Is64BitOperatingSystem ? "WOW6432Node\\" : "") + "Notepad++";
            var registryPath86 = "SOFTWARE\\Notepad++";
            if (Registry.LocalMachine.OpenSubKey(registryPath64) == null && 
                Registry.LocalMachine.OpenSubKey(registryPath86) == null) {
                if (MessageBox.Show("您的计算机还没有安装Notepad++，现在去安装吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    Process.Start("https://notepad-plus-plus.org/");
                }
            } else {
                foreach (var path in TargetPaths) {
                    Process.Start("notepad++.exe", $"\"{path}\"");
                }
            }
            Close();
        }

        private bool Validator(out IEnumerable<string> validPaths) {
            validPaths = new[] {
                Context.AccountSetsConfiguration_dcxml_Path,
                Context.AutoRunClient_dcxml_Path,
                Context.Default_dcc_Path,
                Context.Update_config_Path,
                Context.BusinessPackage_dcxml_Path
            }.Where(_ => File.Exists(_));
            return validPaths.Count() > 0;
        }

        private IEnumerable<string> GetTargets() {
            IList<string> paths = new List<string>();
            if (cboxIncludeAccountSetsConfiguration_dcxml.Checked) paths.Add(Context.AccountSetsConfiguration_dcxml_Path);
            if (cboxIncludeAutoRunClient_dcxml.Checked) paths.Add(Context.AutoRunClient_dcxml_Path);
            if (cboxIncludeDefault_dcc.Checked) paths.Add(Context.Default_dcc_Path);
            if (cboxIncludeUpdate_config.Checked) paths.Add(Context.Update_config_Path);
            if (cboxIncludeWeb_config.Checked) paths.Add(Context.Web_config_Path);
            if (cboxIncludeBusinessPackage_dcxml.Checked) paths.Add(Context.BusinessPackage_dcxml_Path);
            return paths;
        }
    }
}
