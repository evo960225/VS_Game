using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 簡易RPG.Class;
using System.Windows.Forms;

namespace 簡易RPG {
    class BattleSystem {
        FormGame fg;
        public BattleSystem() {

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
            }
            return false;
        }

        /*public bool Batttle(Map map ,Numerical a, point aloc) {
            
            if (aloc.x == bloc.x && Math.Abs(aloc.y - bloc.y) == 1
             || aloc.y == bloc.y && Math.Abs(aloc.x - bloc.x) == 1) {
                b.hp -= a.atk - b.def;
                if (b.hp < 0) {
                    b.hp = 0;
                    return true;
                }
            }
            return false;
        }*/

    }
}
