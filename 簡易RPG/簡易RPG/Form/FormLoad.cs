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
                if (count > 1) {
                    labName2.Text = databaseDataSet.role_name[1]["rname"].ToString();
                    if (count > 2) {
                        labName3.Text = databaseDataSet.role_name[2]["rname"].ToString();
                    }
                }
            }
            
        }

        private void butLoad1_Click(object sender, EventArgs e) {

        }

        private void _123ToolStripButton_Click(object sender, EventArgs e) {


        }

        private void rolenameBindingSource_CurrentChanged(object sender, EventArgs e) {

        }

        private void getNameToolStripButton_Click(object sender, EventArgs e) {
            try {
                //this.role_nameTableAdapter.GetName(this.databaseDataSet.role_name);
            } catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        

    }
}
