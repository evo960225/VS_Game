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
using RPGControl;

namespace 簡易RPG
{
    public partial class FormGame : System.Windows.Forms.Form
    {
        
        public const int SizeX = 1000;
        public const int SizeY = 700;

        Map map=new Map();
        Player ply = new Player();
        NPC npc = new NPC(false);
        EscPanel Esc;
        skillPanel skill;
        rolePanel rolePnl;
        quickSlotPanel qukPnl;

        public FormGame() {
            InitializeComponent();
            KeyDown += new KeyEventHandler(FormGame_KeyDown);
            this.KeyPreview = true;
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
           // this.Focus();
            if(m.Msg == KEYDOWN) {
                keycode = (int)m.WParam;
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

         void FormGame_KeyDown(object sender, KeyEventArgs e) {
             
             int keycode = (int)e.KeyCode;
             if (keycode>=37 && keycode<=40) {
                 move(keycode);
             } else if (keycode >> 4 == 3) {

             } else {
                 switch (keycode) {
                     case KEY_ESC:
                         Esc = new EscPanel();
                         Esc.Location = new Point(400, 300);
                         this.Controls.Add(Esc);
                         Esc.KeyDown += FormGame_KeyDown;
                         
                         Esc.BringToFront();
                         Esc.TabStop = false;
                         break;
                         
                     case (int)Keys.C:
                         rolePnl = new rolePanel();
                         rolePnl.Location = new Point(400, 300);
                         this.Controls.Add(rolePnl);
                         rolePnl.BringToFront();
                         this.Focus(); break;
                     case (int)Keys.D:
                         skill = new skillPanel();
                         skill.Location = new Point(400, 300);
                         this.Controls.Add(skill);
                         skill.BringToFront();
                         this.Focus(); break;
                     case (int)Keys.I:
                         // Inventory
                         break;
                     case (int)Keys.K:
                         //skill
                         break;
                     case (int)Keys.L:
                         //Quest
                         break;
                     case (int)Keys.Q:
                         qukPnl = new quickSlotPanel();
                         qukPnl.Location = new Point(400, 300);
                         this.Controls.Add(qukPnl);
                         qukPnl.BringToFront();
                         qukPnl.Focus(); 
                         break;
                 }
                 
             }
             
         }

         private void FormGame_KeyPress(object sender, KeyPressEventArgs e) {
            
         }

         private void FormGame_KeyUp(object sender, KeyEventArgs e) {
             
         }

         private void FormGame_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
             int a = 5;
         }
    }

}

