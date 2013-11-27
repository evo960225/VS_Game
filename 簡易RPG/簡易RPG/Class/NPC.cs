using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace 簡易RPG {
    class NPC : 簡易RPG.Class.Organism {

        enum Sex{
            male   = 0 ,
            female = 1
        }
        Sex sex = Sex.male;

        const int sizeW = 50;
        const int sizeH = 50;
        const double SEC = 1000.0;

        //座標
        int timV = (int)(1 * SEC);

        string adrImg = "..\\..\\images\\人物.png";
        bool isStand;

        Timer timer;
        
        public NPC(bool stand = true) {
            numerical.name = "NPC";
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

    }
}
