using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 簡易RPG {
    public partial class FormWait : System.Windows.Forms.Form {
        Timer tim = new Timer();
        
        public FormWait() {
            InitializeComponent();

        }

        private void FormWait_Load(object sender, EventArgs e) {
            tim.Interval = 200;
            tim.Tick += tim_Tick;
            tim.Start();
        }

        void tim_Tick(object sender, EventArgs e) {
            progressBar1.Value += 10;
        }
    }
}
