using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 簡易RPG.Class;
using System.Windows.Forms;
using System.Drawing;

namespace 簡易RPG {
    class BattleSystem {
        Label labPenel;
        FormGame fg;
        Timer tim = new Timer();
        Queue queLab = new Queue();
        public BattleSystem(FormGame f) {
            labPenel = f.labBG;
            fg = f;
            tim.Interval = 24;
            tim.Tick += tim_Tick;
            tim.Start();
        }

        void tim_Tick(object sender, EventArgs e) {
            foreach (Label lab in queLab) {
                lab.Location = new Point(lab.Location.X, lab.Location.Y - 1);  
                lab.Tag = (int)lab.Tag - 1;
            }
            if (queLab.Count != 0 && (int)((Label)queLab.Peek()).Tag <= 0 || queLab.Count > 5) {
                ((Label)queLab.Peek()).Dispose(); 
                queLab.Dequeue();
            }
        }
        
        public void Batttle(Numerical a,Numerical b) {
            b.hp -= a.atk - b.def;
            if (b.hp < 0) b.hp = 0;
        }

        public bool Batttle(Numerical a,point aloc, Numerical b,point bloc) {
            if (aloc.x == bloc.x && Math.Abs(aloc.y - bloc.y) == 1
             || aloc.y == bloc.y && Math.Abs(aloc.x - bloc.x) == 1) {
                b.hp -= a.atk - b.def;
                if (b.hp < 0) {
                    b.hp = 0;
                    return true;
                }
                Label labHit = new Label();
                //labHit.Location = new Point(b..x, obj.picLoc.y - 10);
                labHit.ForeColor = Color.White;
                labHit.BackColor = Color.Transparent;
                labHit.Tag = 24 * 3;
                labHit.Font = new Font("微軟正黑體", 16);
                //labHit.Text = (a.atk - obj.numerical.def).ToString();
                labHit.Size = new Size(20, 20);
                queLab.Enqueue(labHit);
                fg.Controls.Add(labHit);
                labHit.Parent = labPenel;
                labHit.BringToFront(); 

            }
            return false;
        }

        public void  Batttle(Player ply, Queue qu) {
            Numerical a = ply.numerical;
            foreach (Monster obj in qu) {
                Numerical b = obj.numerical;
                if (ply.loc.x == obj.loc.x && Math.Abs(ply.loc.y - obj.loc.y) == 1
                 || ply.loc.y == obj.loc.y && Math.Abs(ply.loc.x - obj.loc.x) == 1) {
                     obj.numerical.hp -= a.atk - obj.numerical.def;
                     Label labHit    = new Label();
                    labHit.Location  = new Point(obj.pic.Location.X, obj.pic.Location.Y- 10);
                    labHit.ForeColor = Color.White;
                    labHit.BackColor = Color.Transparent; 
                    labHit.Tag       = 24 * 3;
                    labHit.Font      = new Font("微軟正黑體", 16);
                    labHit.Text      = (a.atk - b.def).ToString();
                    labHit.Size      = new Size(20, 20); 
                    queLab.Enqueue(labHit);
                    fg.Controls.Add(labHit);
                    labHit.Parent = labPenel;
                    labHit.BringToFront(); 

                    if (b.hp < 0) {
                        b.hp = 0;
                        obj.Dispose();
                    } 
                }
            }
            //return false;
        }


        
    }
}
