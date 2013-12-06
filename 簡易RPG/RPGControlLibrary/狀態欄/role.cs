using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 狀態欄 {
    public partial class role : UserControl {
        public role() {
            InitializeComponent();
        }

        private void role_Load(object sender, EventArgs e) {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
    }
}
