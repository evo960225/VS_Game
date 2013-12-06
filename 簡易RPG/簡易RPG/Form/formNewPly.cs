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
using 簡易RPG.Class;

namespace 簡易RPG {
    public partial class FormNewPly : System.Windows.Forms.Form {

        FormGame formgame;
        Player ply;

        public FormNewPly() {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e) {
            // TODO: 這行程式碼會將資料載入 'databaseDataSet.role_name' 資料表。您可以視需要進行移動或移除。
            this.role_nameTableAdapter.Fill(this.databaseDataSet.role_name);
        }

        private void button1_Click(object sender, EventArgs e) {

            ply = new Player(tetName.Text, (int)numHP.Value, (int)numSP.Value, (int)numA.Value, (int)numD.Value);
            ply.saveToText();
            this.Hide();
            formgame = new FormGame(ply);
            formgame.Visible = true;
        }

        private void escPanel1_Load(object sender, EventArgs e) {
           
        }
    }
}

