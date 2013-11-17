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
//using System.Data;
//using System.Data.SqlClient;
//using System.Data.SqlTypes;
//using Microsoft.SqlServer.Server;

namespace 簡易RPG
{
    public partial class FormGame : Form
    {
        public const int SizeX = 1000;
        public const int SizeY = 700;

        Map map=new Map();
        Player ply = new Player();

        public FormGame() {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e) {

            map.create();
            for (int i = 0; i < 14; ++i) {
                for (int j = 0; j < 20; ++j) {
                    this.Controls.Add(map.pic[i, j]);
                }
            }
            //this.Controls.Add(map.pi);

            ply.loadPly();
            this.Controls.Add(ply.pic);
            ply.pic.BringToFront();
        }


        const int KEYDOWN = 0x100;
        bool ismove;
        int keycode;
        const int KEY_LEFT = 37;
        const int KEY_DOWN = 40;
        const int KEY_ESC = 27;
        protected override void WndProc(ref Message m) {

            base.WndProc(ref m);

            if(m.Msg == KEYDOWN) {
                keycode = (int)m.WParam;
                if(keycode >= KEY_LEFT && keycode <= KEY_DOWN) {
                    move(keycode);
                } else if(keycode ==KEY_ESC) {

                }

                
            }
        }

         public void move(int code){
             bool mapMove = false;
             if(code == 37) {
                 if(ply.getLocX > 500) {
                     ply.move(code);
                 } else {
                     mapMove=true;
                 }
             }else if(code==38){
                 if(ply.getLocY > 350) {
                     ply.move(code);
                 }else {
                     mapMove=true;
                 }
             }else if(code==39){
                 if(ply.getLocX < 500) {
                     ply.move(code);
                 }else {
                     mapMove=true;
                 }
             }else{
                 if(ply.getLocY < 350) {
                     ply.move(code);
                 }else {
                     mapMove = true;
                 }
             }
             if(mapMove) {
                 ismove = map.move(code - 37);
                 if(!ismove) {
                     ply.move(code);
                 }
             }

        }

        


    }
}
