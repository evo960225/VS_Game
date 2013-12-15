using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 簡易RPG;

namespace 簡易RPG.Class {
    class AI:Organism  {
        public const double SEC = 1000.0;
        public int timV = (int)(0.9 * SEC);
        public Timer timer;
        Random rnd = new Random((int)DateTime.Now.Ticks);

        public void timerMove(object sender, EventArgs e) {
            int vec = rnd.Next(0, 4);
            picAndLocMaove(vec);
        }
        public void trackMnemy() {
            
        }

    }
}
