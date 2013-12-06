using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace 簡易RPG.Class {
    class Monster : 簡易RPG.Class.AI {

        const double SEC = 1000.0;
        const string AdrImg = "..//..//images//怪物a.png";

        Timer timer;

        int timV = (int)(0.9 * SEC);
        
        public Monster(string na = "", int l = 1, int h = 1, int s = 1, int a = 1, int d = 1) {
            numerical.name = na;
            numerical.lv = l;
            numerical.hp = h;
            numerical.sp = s;
            numerical.atk = a;
            numerical.def = d;
            Init();
        }

        public Monster(Numerical numer) {
            numerical = numer;
            Init();
        }

        public void Init() {
            loadPic("mon",AdrImg);
            timer = new Timer();
            timer.Tick += new System.EventHandler(timerMove);
            timer.Interval = timV;
            timer.Start();
        }
    }
}
