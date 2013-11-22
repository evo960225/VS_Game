using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class EscPanel: UserControl
    {
        //public event EventHandler TaxTextChanged; 
        //public delegate void myDelegate(string welkin);
        //public event myDelegate welkinEvent;
        public EscPanel()
        {
            InitializeComponent();
        }

        private void EscPanel_Load(object sender, EventArgs e) {
           
        }

        private void EscPanel_DragDrop(object sender, DragEventArgs e) {
            
        }

        private void butExit_Click(object sender, EventArgs e) {

        }

        private void butContinue_Click(object sender, EventArgs e) {
            this.Visible = false;
        }
    }
}
