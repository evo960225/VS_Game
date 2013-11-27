using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using 簡易RPG.Class;

namespace 簡易RPG {
    public class Player:簡易RPG.Class.Organism {

        const string AdrImg = "..//..//images//人物2.png";

        const int ImgX = 50;
        const int ImgY = 50;
        

        public Player() {
            img = new Bitmap(AdrImg);
            pic.Image = img;
            this.numerical.name = "0";
            this.numerical.hp = 1;
            this.numerical.sp = 1;
            this.numerical.atk = 1;
            this.numerical.def = 1;
            createPic();
        }

        public Player(string na, int h = 1, int s = 1, int a = 1, int d = 1) {
            img = new Bitmap(AdrImg);
            pic.Image = img;
            this.numerical.name = na;
            this.numerical.hp = h;
            this.numerical.sp = s;
            this.numerical.atk = a;
            this.numerical.def = d;
            createPic();
        }

        public int getLocX {
            get { return picLocX; }
        }

        public int getLocY {
            get{return picLocY; }
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

        public void createPic() {
            pic = new Label();
            pic.Name = "picPly";
            pic.Size = new Size(50, 50);
            pic.Location = new Point(500, 350);
            pic.Image = img;
        }

        public void move(int keyCode) {

            if(keyCode == 37 && picLocX != 0) {
                picLocX -= ImgX;
            } else if(keyCode == 38 && picLocY != 0) {
                picLocY -= ImgY;
            } else if(keyCode == 39 && picLocX != FormGame.SizeX - ImgX) {
                picLocX += ImgX;
            } else if(keyCode == 40 && picLocY != FormGame.SizeY - ImgY) {
                picLocY += ImgY;
            }
            pic.Location = new Point(picLocX, picLocY);
        }
    }
}
