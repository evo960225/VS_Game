using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using 簡易RPG.Class;

namespace 簡易RPG.Class {
    public class Player:Organism {

        const string AdrImg = "..//..//images//人物2.png";

        const int ImgX = 50;
        const int ImgY = 50;

        public Player() {
            img = new Bitmap(AdrImg);
            this.numerical.name = "0";
            this.numerical.hp = 1;
            this.numerical.sp = 1;
            this.numerical.atk = 1;
            this.numerical.def = 1;
            loadPic("picPly", AdrImg);
        }
        public Player(string na, int h = 1, int s = 1, int a = 1, int d = 1) {
            img = new Bitmap(AdrImg);
            this.numerical.name = na;
            this.numerical.hp = h;
            this.numerical.sp = s;
            this.numerical.atk = a;
            this.numerical.def = d;
            loadPic("picPly", AdrImg);
        }
        public Player(Numerical n) {
            numerical = n;
            loadPic("picPly", AdrImg);
        }

        public void saveToText() {

            FileStream fs = new FileStream("in.txt", FileMode.Create);
            string st = "Name:" + this.numerical.name + "\nHP:" + this.numerical.hp + "\nSP:" + this.numerical.sp + "\nA:" + this.numerical.atk + "\nD:" + this.numerical.def;
            byte[] b = Encoding.Default.GetBytes(st);

            fs.Write(b, 0, b.Length);
            fs.Close();
        }

        public void loadPly() {
            FileStream fs = new FileStream("in.txt", FileMode.Open);
            string st;
            byte[] b = new byte[1000];

            fs.Read(b, 0,1000);
            st = Encoding.Default.GetString(b);
            fs.Close();
        }
    }
}
