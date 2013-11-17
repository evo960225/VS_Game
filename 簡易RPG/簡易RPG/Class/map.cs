using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;


namespace 簡易RPG {
    public class Map {

        //***建置需更改***//
        const string AdrMap = "..//..//map//";
        const string AdrImg = "..//..//images//";
        
        const int SizeX = 20;
        const int SizeY = 14;
        const int ImgSizeW = 50;
        const int ImgSizeH = 50;

        int bigSizeX;
        int bigSizeY;
        int locX;
        int locY;

        #region
        string[] MapID = new string[] { "草地", "石路", "河流", "岩石" };
        Bitmap[] img = new Bitmap[4];
        

        #endregion

        int[,] arrBigMap = new int[500, 500];
        //int[,] arrVisMap = new int[SizeY, SizeX];
        public PictureBox[,] pic = new PictureBox[SizeY, SizeX];
        byte[] buf = new byte[10000];

        public Map() {
            fileLoad();
        }

        public void fileLoad() {
            
            FileStream fs = new FileStream(AdrMap + "map.txt", FileMode.Open);
            fs.Read(buf, 0, 10000);
            
            bigSizeX = 24;
            bigSizeY = 20;
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
            for(int i = 0; i < MapID.Length-1; ++i) {
                img[i] = new Bitmap(AdrImg + Convert.ToString(MapID[i]) + ".png");
            }
        }

        public void create() {

            picLoad();

            for(int i = 0; i < SizeY; ++i) {
                for(int j = 0; j < SizeX; ++j) {
                    pic[i, j] = new PictureBox();
                    pic[i, j].Name = "pic" + Convert.ToString(i * SizeY + j);
                    pic[i, j].Size = new Size(ImgSizeW, ImgSizeH);
                    pic[i, j].Image = img[arrBigMap[i + locX, j + locY]];
                    pic[i, j].Location = new Point(j * ImgSizeW, i * ImgSizeH);
                    pic[i, j].Tag = i * SizeY + j;
                    
                }
            }
        }

        public bool move(int vec) {

            if(vec == 0 && locX != 0) {
                --locX; 
            } else if(vec == 1 && locY!=0) {
                --locY;
            } else if(vec == 2 && locX+SizeX != bigSizeX) {
                ++locX;
            } else if(vec == 3 && locY + SizeY != bigSizeY) {
                ++locY;
            } else {
                return false;
            }

            for(int i = 0; i < SizeY; ++i) {
                for(int j = 0; j < SizeX; ++j) {
                    pic[i, j].Image = img[arrBigMap[i + locY, j + locX]];
                }
            }

            return true;
        }
    }
}
