using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace 簡易RPG.Class {
    public class Organism {
        public Numerical numerical=new Numerical();
        public Bitmap img;
        public Label pic = new Label();
        public int locX = 500;
        public int locY = 350;
        public  int picLocX = 500;
        public  int picLocY = 350;
        public void move(int vec) {
            if (vec == 0) {
                locX -= 50;
            } else if (vec == 1) {
                locY -= 50;
            } else if (vec == 2) {
                locX += 50;
            } else if (vec == 3) {
                locY += 50;
            }
            pic.Location = new Point(locX, locY);
        }
        Random rnd = new Random();
        public void timerMove(object sender, EventArgs e) {
            int vec = rnd.Next(0, 4);
            move(vec);
        }
    }
}
