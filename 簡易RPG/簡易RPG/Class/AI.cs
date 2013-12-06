using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 簡易RPG.Class {
    class AI:Organism  {
        Random rnd = new Random((int)DateTime.Now.Ticks);
        public void timerMove(object sender, EventArgs e) {
            int vec = rnd.Next(0, 4);
            picAndLocMaove(vec);
        }
    }
}
