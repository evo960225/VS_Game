using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace 簡易RPG {
    class NPC {

        enum Sex{
            male   = 0 ,
            female = 1
        }
        Sex sex = Sex.male;

        const int sizeW = 50;
        const int sizeH = 50;
        const double SEC = 1000.0;

        //座標
        int locX = 500;
        int locY = 300;
        int timV = (int)(0.5 * SEC);

        string name = "NPC";
        string adrImg = "..\\..\\images\\人物.png";
        bool isStand;

        public Label pic;
        Image img;
        Timer timer;
        Random rnd = new Random();

        #region
        /*
        int hp;
        int maxHp;
        int sp;
        int maxSp;
        int atk;
        int def;
        int exp;
        int maxExp;
        int lv;
         */
        #endregion
        
        public NPC(bool stand = true) {
            
            isStand = stand;
            if (!isStand) {
                timer = new Timer();
                timer.Tick += new System.EventHandler(timerMove);
                timer.Interval = timV;
                timer.Start();
            }
            img = new Bitmap(adrImg);
            pic = new Label();
            pic.Name = "NPC";
            pic.Location = new Point(locX, locY);
            pic.Size = new Size(sizeW, sizeH);
            pic.Image = img;
        }

        public void init() {

        }

        public void timerMove(object sender, EventArgs e) {
            int vec = rnd.Next(0, 4);
            move(vec);
        }

        public void move(int vec){
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
    }
}
