﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 簡易RPG
{
    public partial class FormTitle : System.Windows.Forms.Form
    {
        FormNewPly fm = new FormNewPly();
        FormLoad fl = new FormLoad();
        public FormTitle()
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

        protected override void OnFormClosed(FormClosedEventArgs e) {
            base.OnFormClosed(e);
            Application.Exit();

        }


        private void button2_Click(object sender, EventArgs e) {

        }

        private void butLoad_Click(object sender, EventArgs e) {
            fl.Visible = true;
            this.Hide();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {

        }
    }
}
