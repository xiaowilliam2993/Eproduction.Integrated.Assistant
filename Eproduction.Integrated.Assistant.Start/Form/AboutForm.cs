using Eproduction.Integrated.Assistant.Start.Control;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Start {
    public partial class AboutForm : Form {
        public AboutForm() {
            InitializeComponent();

            var logoControl = new LogoControl();
            logoControl.Name = "LogoControl";
            logoControl.Size = new Size(177, 49);
            logoControl.Location = new Point(24, 22);
            logoControl.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Controls.Add(logoControl);
        }

        private void AboutForm_Load(object sender, EventArgs e) {
            var assembly = Assembly.GetExecutingAssembly();
            lblReleaseVersion.Text = assembly.GetName().Version.ToString();
            lblAuthor.Text = "<William Fu> mailto:fuwei@digiwin.com";
            lblProductDescription.Text = ((AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyDescriptionAttribute))).Description;
        }

        private void AboutForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                Close();
            }
        }
    }
}
