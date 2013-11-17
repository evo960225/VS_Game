using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace 簡易RPG {
    public class Player {

        const string AdrImg = "..//..//images//人物.png";

        const int ImgX = 50;
        const int ImgY = 50;

        private string name;
        private int hp;
        private int sp;
        private int atk;
        private int def;

        private int locX = 10;
        private int locY = 7;
        private int picLocX = 500;
        private int picLocY = 350;

        public PictureBox pic;
        private Bitmap img = new Bitmap(AdrImg);
        

        public Player() {
            createPic();
        }

        public Player(string na, int h = 1, int s = 1, int a = 1, int d = 1) {
            name = na;
            hp = h;
            sp = s;
            atk = a;
            def = d;
        }

        public int getLocX {
            get { return picLocX; }
        }

        public int getLocY {
            get{return picLocY; }
        }

        public void saveToText() {

            FileStream fs = new FileStream("in.txt", FileMode.Create);
            string st = "Name:" + name + "\nHP:" + hp + "\nSP:" + sp + "\nA:" + atk + "\nD:" + def;
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
            pic = new PictureBox();
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
