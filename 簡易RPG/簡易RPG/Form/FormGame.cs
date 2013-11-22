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
using WindowsFormsControlLibrary;
using 技能欄;

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
        NPC npc = new NPC(false);
        EscPanel Esc;
        skillPanel skill;
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

            ply.loadPly();
            this.Controls.Add(ply.pic);
            ply.pic.BringToFront();
            this.Controls.Add(npc.pic);
            npc.pic.BringToFront();

        }
        
        int keycode;
        const int KEYDOWN = 0x100;
        const int KEY_LEFT = 37;
        const int KEY_DOWN = 40;
        const int KEY_ESC  = 27;
        const int KEY_C    = 99;
        const int KEY_D    = 100;

        protected override void WndProc(ref Message m) {

            if(m.Msg == KEYDOWN) {
                keycode = (int)m.WParam;
                if (keycode >= KEY_LEFT && keycode <= KEY_DOWN) {
                    move(keycode);
                } else if (keycode == KEY_ESC) {
                    Esc = new EscPanel();
                    Esc.Location = new Point(400, 300);
                    this.Controls.Add(Esc);
                    Esc.BringToFront();
                } else if (keycode == (int)Keys.C) {
                    skill = new skillPanel();
                    skill.Location = new Point(400, 300);
                    this.Controls.Add(skill);
                    skill.BringToFront();
                } else if (keycode == (int)Keys.D){
                    skill = new skillPanel();
                    skill.Location = new Point(400, 300);
                    this.Controls.Add(skill);
                    skill.BringToFront();
                    this.Focus();
                }
            }
            base.WndProc(ref m);
        }

         public void move(int code){

             bool mapMove = true;
             if(code == 37 && ply.getLocX > 500) {
                     mapMove = false;
             }else if(code==38 && ply.getLocY > 350){
                     mapMove = false;
             }else if(code==39 && ply.getLocX < 500){
                     mapMove = false;
             } else if (code == 40 && ply.getLocY < 350) {
                 mapMove = false;
             }
             if (mapMove && !map.move(code - 37) || (!mapMove)) {
                 ply.move(code);
             }
        }

         private void timer1_Tick(object sender, EventArgs e) {

         }

    }
}
