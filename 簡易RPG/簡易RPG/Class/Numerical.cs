using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 簡易RPG {
    public class Numerical {

        public string name = "0";
        public int lv      = 1;
        public int hp      = 1;
        public int sp      = 1;
        public int maxHp   = 1;
        public int maxSp   = 1;
        public int atk     = 1;
        public int def     = 1;
        public int addHp   = 0;
        public int addSp   = 0;
        public int addAtk  = 0;
        public int addDef  = 0;

        public Numerical() {

        }

        public Numerical(string na, int l, int h, int s, int mh, int ms, int at, int de, int ahp, int asp, int aat, int adf) {
            name = na;
            lv = l;
            hp = h ;
            sp = s;
            maxHp = mh;
            maxSp = ms;
            atk = at;
            def = de;
            addHp = ahp;
            addSp = asp;
            addAtk = aat;
            addDef = adf;
        }

    }
}
