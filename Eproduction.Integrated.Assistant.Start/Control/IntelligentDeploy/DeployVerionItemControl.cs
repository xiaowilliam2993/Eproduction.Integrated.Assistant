using System;
using System.Drawing;
using System.Windows.Forms;
using Eproduction.Integrated.Assistant.Start.Core;

namespace Eproduction.Integrated.Assistant.Start.Control {
    public partial class DeployVerionItemControl : UserControl {
        private DeployVersionContext _context = null;
        private bool _isSelected = false;
        public DeployVersionContext Context {
            get => _context;
        }
        public bool IsSelected {
            get => _isSelected;
            set {
                _isSelected = value;

                lblSelectedPrompt.Visible = _isSelected;

                if (_isSelected) {
                    BackColor = Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
                } else {
                    BackColor = Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
                }
            }
        }
        public DeployVerionItemControl(DeployVersionContext context) {
            InitializeComponent();

            _context = context;
        }

        private void DeployVerionItemControl_Load(object sender, EventArgs e) {
            BindingSource.DataSource = Context;
            lblVersion.DataBindings.Add(new Binding("Text", BindingSource, "Name", false, DataSourceUpdateMode.OnPropertyChanged));
        }
    }
}
