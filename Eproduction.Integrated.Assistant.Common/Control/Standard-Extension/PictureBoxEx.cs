﻿using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Common.Control {
    public partial class PictureBoxEx : PictureBox {
        public const int WS_EX_TRANSPARENT = 0x20;
        protected override CreateParams CreateParams {
            get {
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
                CreateParams result = base.CreateParams;
                result.ExStyle = result.ExStyle | WS_EX_TRANSPARENT;
                return result;
            }
        }
    }
}
