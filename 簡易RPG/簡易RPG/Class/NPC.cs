using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using 簡易RPG.Class;

namespace 簡易RPG {
    class NPC : AI {

        string adrImg = "..\\..\\images\\人物.png";
        bool isStand;
        
        public NPC(bool stand = true) {
            numerical.name = "NPC";
            isStand = stand;
            if (!isStand) {
                timer = new Timer();
                timer.Tick += new System.EventHandler(timerMove);
                timer.Interval = timV;
                timer.Start();
            }
            loadPic("NPC",adrImg);
        }

        public void killed(){
            pic.Visible = false;
            timer.Dispose();
        }

        ~NPC() {

        }

        public void init() {

        }

    }
}
