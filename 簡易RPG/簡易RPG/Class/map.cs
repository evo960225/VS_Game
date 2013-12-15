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

        //***** 地址 *****//
        //** 建置需更改 **//
        const string AdrMap = "..//..//map//";
        const string AdrImg = "..//..//images//";

        //***** 大小 *****//
        const int SizeX     = 20;
        const int SizeY     = 14;
        const int ImgSizeW  = 50;
        const int ImgSizeH  = 50;
        int bigSizeX        = 24;
        int bigSizeY        = 24;
        int locX            =  0;
        int locY            =  0;
        int cameraFocusLocX = 10;
        int cameraFocusLocY =  7;

        //***** 陣列 *****//
        int   [,] arrBigMap   = new int   [200, 200];
        string[,] arrInBigMap = new string[200, 200];
        byte  []  buf         = new byte  [10000];
        string[]  MapID       = new string[] { "草地", "石路", "河流", "岩石", "樹林" };

        //***** 物件 *****//
        Bitmap[]    mapBlockImg = new Bitmap[5];
        Bitmap      bmpBG       = new Bitmap(1000, 700);
        Graphics    g;
        Hashtable   hashOrg      = new Hashtable();
        Timer       timRefresh;
        Label       labPenel;
        Label       cameraFocus;

        public Map() {
            fileLoad();
            picLoad();
            
            Timer timRefresh = new Timer();
            timRefresh.Tick+=timRefresh_Tick;
            timRefresh.Start();
        }

        private void timRefresh_Tick(object sender, EventArgs e) {
            string name = "";
            int x = 0, y = 0;
            foreach (object key in hashOrg.Keys) {
                
                if (key.ToString().Substring(0, 3) == "NPC") {
                    NPC npc = (NPC)hashOrg[key];
                    name = npc.numerical.name;
                    x = npc.loc.x;
                    y = npc.loc.y;
                } else if (key.ToString().Substring(0, 3) == "mon") {
                    Monster monster = (Monster)hashOrg[key];
                    name = monster.numerical.name;
                    x = monster.loc.x;
                    y = monster.loc.y;
                }
                arrInBigMap[y, x] = key.ToString();
            }
        }


        public void fileLoad() {
            
            FileStream fs = new FileStream(AdrMap + "map.txt", FileMode.Open);
            fs.Read(buf, 0, 10000);
            
            bigSizeX = 25;
            bigSizeY = 22;
            locX     =  0;
            locY     =  0;

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

        public void create(Label formbmpBG) {
            labPenel      = formbmpBG;
            labPenel.Size = new Size  (bigSizeX * 50, bigSizeY * 50);
            bmpBG         = new Bitmap(bigSizeX * 50, bigSizeY * 50);
            g             = Graphics.FromImage(bmpBG);

            for(int i = 0; i < bigSizeY; ++i) {
                for(int j = 0; j < bigSizeX; ++j) {
                    g.DrawImage(mapBlockImg[arrBigMap[i, j]], new Point(j * 50, i * 50));
                }
            }
            formbmpBG.BackgroundImage = bmpBG;
        }
        
        public bool move(int vec) {
            sbyte xAdd = 0, yAdd = 0;
            if       (vec == 0 && locX != 0) {
                --locX;
                xAdd = 1;
            } else if(vec == 1 && locY != 0) {
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
            labPenel.Location = new Point(-(locX * 50), -(locY * 50));
            return true;
        }

        public Point  getDistance(){
            return new Point(0, 0);
        }

        public Queue searchMatrixObj(int distance,int x,int y) {
            Queue qu = new Queue();
            int size = distance * 2 + 1;
            cameraFocusLocX = x;
            cameraFocusLocY = y; 
            for (int i = 0 ; i < size ; ++i) {
                for (int j = 0 ; j < size ; ++j) {
                    x = j + cameraFocusLocX - distance;
                    y = i + cameraFocusLocY - distance;
                    if (arrInBigMap[y, x]!=null && arrInBigMap[y, x].IndexOf("mon")==0) {
                        qu.Enqueue(hashOrg[arrInBigMap[y, x]]);
                    }
                }
            }
            return qu;
        }

        public void setCamera(Label lab) {
            lab.Parent = labPenel;
            cameraFocus = lab;
        }

        static int objCount = 0;
        public void addOrganPic(Label obj) {
            obj.Parent = labPenel;
            hashOrg.Add(objCount++, obj);
        }


        public void addOrganPic(object obj) {
            if (obj.GetType() == typeof(NPC)) {
                NPC npc = (NPC)obj;
                npc.pic.Parent = labPenel;
                hashOrg.Add(npc.numerical.name + objCount, npc);
            } else if (obj.GetType() == typeof(Monster)) {
                Monster monster = (Monster)obj;
                monster.pic.Parent = labPenel;
                hashOrg.Add(monster.numerical.name + objCount, monster);
            }
            objCount++;
        }

        public void removeHashOrg(string name) {
            
        }

        public void searchSquare(int size) {

        }
        public void searchSquare(string name, int size) {

        }
        public Queue<string> searchSquare(point loc, int size) {
            Queue<string> qu = new Queue<string>();
            size = size * 2 + 1;
            for (int i = 0 ; i < size ; ++i) {
                if (loc.y - 1 + i >= 0) {
                    for (int j = 0 ; j < size ; ++j) {
                        if (loc.x - 1 + j >= 0) {
                            qu.Enqueue(arrInBigMap[i, j]);
                        }
                    }
                }
            }
            return qu;
        }

        public void searchCross(int size) {

        }
        public void searchCross(string name, int size) {

        }
        public void searchCross(point loc, int size) {

        }

        public void searchKnightStep(int size) {

        }
        public void searchKnightStep(string name, int size) {

        }
        public void searchKnightStep(point loc, int size) {

        }

        public void searchX(int size) {

        }
        public void searchX(string name, int size) {

        }
        public void searchX(point loc, int size) {

        }

        public void searchLozenge(point loc, int size) {

        }
    }
}
