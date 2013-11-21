using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace 簡易RPG {
    public partial class FormNewPly : Form {

        FormGame formgame;
        Player ply;

        public FormNewPly() {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e) {
        }

        private void button1_Click(object sender, EventArgs e) {

            ply = new Player(tetName.Text, (int)numHP.Value, (int)numSP.Value, (int)numA.Value, (int)numD.Value);
            ply.saveToText();
            this.Hide();
            formgame = new FormGame();
            formgame.Visible = true;
        }

        private void escPanel1_Load(object sender, EventArgs e) {
           
        }
    }
}

