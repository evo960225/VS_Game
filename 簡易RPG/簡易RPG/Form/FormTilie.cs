using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsControlLibrary;
namespace 簡易RPG
{
    public partial class Form1 : Form
    {
        FormNewPly fm = new FormNewPly();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fm.Visible = true;
            this.Hide();
        }

        private void butExit_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e) {
            /*WindowsFormsControlLibrary.EscPanel.
            foreach (Control a in escPanel1.Controls) {
                a.KeyDown(a, new EventArgs())+=a;
            }*/
        }

        private void escPanel1_Load(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {

        }
    }
}
