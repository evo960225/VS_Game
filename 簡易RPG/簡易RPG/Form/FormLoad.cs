using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace 簡易RPG {
    public partial class FormLoad : System.Windows.Forms.Form {
        public FormLoad() {
            InitializeComponent();
        }

        private void FormLoad_Load(object sender, EventArgs e) {

            role_nameTableAdapter.GetDataName(this.databaseDataSet.role_name);
            int count=databaseDataSet.role_name.Count;
            if (count > 0) {
                labName1.Text = databaseDataSet.role_name[0]["rname"].ToString();
                butLoad1.Visible = true;
                if (count > 1) {
                    labName2.Text = databaseDataSet.role_name[1]["rname"].ToString();
                    butLoad2.Visible = true;
                    if (count > 2) {
                        labName3.Text = databaseDataSet.role_name[2]["rname"].ToString();
                        butLoad3.Visible = true;
                    }
                }
            }
            
        }

        FormGame formgame;
        private void butLoad_Click(object sender, EventArgs e) {

            int index = Convert.ToInt16(((Button)sender).Tag);
            role_dataTableAdapter.Fill(this.databaseDataSet.role_data, index + 1);
            string name;
            name = databaseDataSet.role_data[0]["rname"].ToString();
            int hp = Convert.ToInt16(databaseDataSet.role_data[0]["hp"]);
            int sp = Convert.ToInt16(databaseDataSet.role_data[0]["sp"]);
            int atk = Convert.ToInt16(databaseDataSet.role_data[0]["atk"]);
            int def = Convert.ToInt16(databaseDataSet.role_data[0]["def"]);
            formgame = new FormGame(new Player(name, hp, sp, atk, def));
            formgame.Visible = true;

            this.Dispose();
        }


        private void rolenameBindingSource_CurrentChanged(object sender, EventArgs e) {

        }


        

    }
}
