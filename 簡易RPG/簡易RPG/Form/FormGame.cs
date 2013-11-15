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

namespace 簡易RPG
{
    public partial class FormGame : Form
    {

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
        protected override void WndProc(ref Message m) {
            base.WndProc(ref m);
            if(m.Msg == KEYDOWN) {
                /*switch((int)m.WParam) {
                    case 37:
                        ply.pic.Location =new Point (ply.pic.Location.X-50, ply.pic.Location.Y);break;
                    case 38:
                        ply.pic.Location =new Point (ply.pic.Location.X, ply.pic.Location.Y-50);break;
                    case 39:
                        ply.pic.Location =new Point (ply.pic.Location.X+50, ply.pic.Location.Y);break;
                    case 40:
                        ply.pic.Location =new Point (ply.pic.Location.X, ply.pic.Location.Y+50);break;
                }*/
                map.move((int)m.WParam - 37);
            }
        }

        public void move(){

        }

    }
}
