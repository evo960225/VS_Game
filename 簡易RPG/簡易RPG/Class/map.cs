using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;



namespace 簡易RPG.Class {
    public class Map {

        //***建置需更改***//
        const string AdrMap = "..//..//map//";
        const string AdrImg = "..//..//images//";
        
        const int SizeX = 20;
        const int SizeY = 14;
        const int ImgSizeW = 50;
        const int ImgSizeH = 50;

        int bigSizeX = 24;
        int bigSizeY = 24;
        int locX = 0;
        int locY = 0;

        
        int[,] arrBigMap = new int[500, 500];
        byte[] buf = new byte[10000];
        string[] MapID = new string[] { "草地", "石路", "河流", "岩石", "樹林" };
        Hashtable hashAI = new Hashtable();
        Bitmap[] mapBlockImg = new Bitmap[4];

        Bitmap imgPnl = new Bitmap(1000, 700);
        Bitmap  bg=new Bitmap (1000,700);
        Graphics g;
        Label penel;
        

        public Map() {
            fileLoad();
        }

        public void fileLoad() {
            
            FileStream fs = new FileStream(AdrMap + "map.txt", FileMode.Open);
            fs.Read(buf, 0, 10000);
            
            bigSizeX = 25;
            bigSizeY = 22;
            locX = 0;
            locY = 0;

            for(int i = 0; i < bigSizeY; ++i) {
                for(int j = 0; j < bigSizeX; ++j) {
                    arrBigMap[i, j] = buf[i * (bigSizeX + 2) + j + 7] - 48;
                }
            }
            fs.Close();
        }

        public void picLoad() {
            for(int i = 0; i < MapID.Length; ++i) {
                mapBlockImg[i] = new Bitmap(AdrImg + MapID[i]+".png");
            }
        }

        public void create(Label formBG) {
            penel = formBG;
            penel.Size = new Size(bigSizeX * 50, bigSizeY * 50);
            bg = new Bitmap(bigSizeX * 50, bigSizeY * 50);
            g = Graphics.FromImage(bg);
            picLoad();
            for(int i = 0; i < bigSizeY; ++i) {
                for(int j = 0; j < bigSizeX; ++j) {
                    g.DrawImage(mapBlockImg[arrBigMap[i, j]], new Point(j * 50, i * 50));
                }
            }
            formBG.BackgroundImage = bg;
            imgPnl = new Bitmap(bigSizeX * 50, bigSizeY * 50);
            Graphics pp = Graphics.FromImage(imgPnl);
        }

        public void drawIm(Label pic, Image im, Point po) {
            Bitmap b = new Bitmap(50,50);
            Graphics gg = Graphics.FromImage(b);
            gg.DrawImage(mapBlockImg[arrBigMap[po.Y, po.X]], new Point(0, 0));
            gg.DrawImage(new Bitmap(im), new Point(0, 0));
            pic.Image = b;
        }
        
        public bool move(int vec) {
            sbyte xAdd = 0, yAdd = 0;
            if(vec == 0 && locX != 0) {
                --locX;
                xAdd = 1;
            } else if(vec == 1 && locY!=0) {
                --locY;
                yAdd = 1;
            } else if(vec == 2 && locX+SizeX != bigSizeX) {
                ++locX;
                xAdd = -1;
            } else if(vec == 3 && locY + SizeY != bigSizeY) {
                ++locY;
                yAdd = -1;
            } else {
                return false;
            }
            penel.Location = new Point(-(locX * 50), -(locY * 50));
            foreach (Label pic in hashAI.Values) {
                pic.Location = new Point(pic.Location.X + (xAdd * 50), pic.Location.Y + (yAdd * 50));
            }
            return true;
        }

        public Point  getDistance(){
            return new Point(0, 0);
        }

        static int count = 0;
        public void addOrganPic(Label ob) {
            ob.Parent = penel;  
            hashAI.Add(count++, ob);
        }
    }
}
