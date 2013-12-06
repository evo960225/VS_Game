using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace 簡易RPG.Class {
    public class Organism {

        public enum Sex {
            male = 0,
            female = 1
        }
        public Numerical numerical=new Numerical();
        public Bitmap img;
        public Label pic = new Label();

        public point loc = new point(10, 7);
        public point picLoc = new point(500, 350); 

        sbyte xAdd, yAdd;
        public void move(int vec) {
            if (vec == 0 ) {
                --loc.x;
            } else if (vec == 1) {
                --loc.y;
            } else if (vec == 2) {
                ++loc.x;
            } else if (vec == 3) {
                ++loc.y;
            }
        }
        public void picMove(int vec) {
            xAdd = 0; yAdd = 0;
            if (vec == 0) {
                xAdd = -1;
            } else if (vec == 1) {
                yAdd = -1;
            } else if (vec == 2) {
                xAdd = 1;
            } else if (vec == 3) {
                yAdd = 1;
            }
            pic.Location = new Point(pic.Location.X + (xAdd * 50), pic.Location.Y + (yAdd * 50));
        }
        public void picAndLocMaove(int vec) {
            xAdd = 0; yAdd = 0;
            if (vec == 0) {
                --loc.x;
                xAdd = -1;
            } else if (vec == 1) {
                --loc.y;
                yAdd = -1;
            } else if (vec == 2) {
                ++loc.x;
                xAdd = 1;
            } else if (vec == 3) {
                ++loc.y;
                yAdd = 1;
            }
            pic.Location = new Point(pic.Location.X + (xAdd * 50), pic.Location.Y + (yAdd * 50));
        }

        public void loadPic(string name, string adr) {
            pic.Name = name;
            img = new Bitmap(adr);
            pic.Image = img;
            pic.Location = new Point(picLoc.x, picLoc.y);
            pic.Size = new Size(50, 50);
            pic.BackColor = Color.Transparent;
        }
    }

    public class point {
        public int x;
        public int y;
        public point(int a, int b) {
            x = a;
            y = b;
        }
    }
}
