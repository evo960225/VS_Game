using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 角色欄
{
    public partial class rolePanel: UserControl
    {
        public rolePanel()
        {
            InitializeComponent();
        }

        private void butEnter_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
