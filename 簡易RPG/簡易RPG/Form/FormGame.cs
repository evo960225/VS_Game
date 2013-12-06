using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RPGControl;
using System.Runtime.InteropServices;
using 簡易RPG.Class;

namespace 簡易RPG
{
    public partial class FormGame : System.Windows.Forms.Form
    {
        //Size
        public const int SizeX = 1000;
        public const int SizeY = 700;

        //Pic
        Label bgImg = new Label();
        Map map;
        Player ply;
        NPC npc = new NPC(false);
        Monster[] monster = new Monster[4];

        //userControl
        EscPanel Esc = new EscPanel();
        skillPanel skill = new skillPanel();
        rolePanel rolePnl = new rolePanel();
        quickSlotPanel qukPnl = new quickSlotPanel();
        InventoryPanel invPnl = new InventoryPanel();

        BattleSystem BS = new BattleSystem();
        //Application
        KeyMessageFilter filter;


        public FormGame(Player rply) {
            InitializeComponent();
            filter = new KeyMessageFilter(this);
            Application.AddMessageFilter(filter);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            ply = rply;
            rolePnl.loadNum(ply.numerical.name, ply.numerical.lv, ply.numerical.hp, ply.numerical.sp, ply.numerical.hp, ply.numerical.sp, ply.numerical.atk, ply.numerical.def, 0, 0, 0, 0);
            InitObject();  
        }

        void bgImg_Paint(object sender, PaintEventArgs e) { 
            
        }

        void InitObject() {

            bgImg.Paint += bgImg_Paint;
            bgImg.Size = new Size(1000, 700); 
            bgImg.Visible = true;
            this.Controls.Add(bgImg);

            ply.loadPly();
            this.Controls.Add(ply.pic);
            this.Controls.Add(npc.pic);

            map = new Map();
            map.create(bgImg);
            map.drawIm(ply.pic, ply.img, new Point(ply.loc.x, ply.loc.y));

            map.addOrganPic(npc.pic);
           
            ply.pic.BringToFront();
            npc.pic.BringToFront();
            
            for (int i = 0 ; i < 4 ; ++i) {
                monster[i] = new Monster();
                this.Controls.Add(monster[i].pic);
                map.addOrganPic(monster[i].pic);
                monster[i].pic.BringToFront();
            }

            Esc.Visible = false;
            rolePnl.Visible = false;
            skill.Visible = false;
            qukPnl.Visible = false;
            invPnl.Visible = false;
            this.Controls.Add(Esc);
            this.Controls.Add(rolePnl);
            this.Controls.Add(skill);
            this.Controls.Add(qukPnl);
            this.Controls.Add(invPnl);
        }

        protected override void OnFormClosed(FormClosedEventArgs e) {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void FormGame_Load(object sender, EventArgs e) {
            
        }

         public void move(int code){
             ply.move(code - 37); 
             bool mapMove = true;
             if        (code == 37 && ply.pic.Location.X > 500) {
                 mapMove = false;
             } else if (code == 38 && ply.pic.Location.Y > 350) {
                 mapMove = false;
             } else if (code == 39 && ply.pic.Location.X < 500) {
                 mapMove = false;
             } else if (code == 40 && ply.pic.Location.Y < 350) {
                 mapMove = false;
             }
             if (mapMove && !map.move(code - 37) || (!mapMove)) {
                ply.picMove(code - 37); 
             }
             map.drawIm(ply.pic, ply.img, new Point(ply.loc.x, ply.loc.y));
        }

         public void KeyProcessing(int keycode) {
             if (keycode >= 37 && keycode <= 40) {
                 move(keycode);
             } else if (keycode >> 4 == 3) {

             } else {
                 switch ((Keys)keycode) {
                     case Keys.Escape:
                         Esc.Location = new Point(400, 300);
                         Esc.Show();
                         Esc.BringToFront();break;
                     case Keys.A:
                         bool iskill=BS.Batttle(ply.numerical,ply.loc, npc.numerical,npc.loc);
                         if (iskill) npc.killed();
                         break;
                     case Keys.C:
                         rolePnl.Show();
                         rolePnl.BringToFront();break;
                     case Keys.D:
                         break;
                     case Keys.I:
                         invPnl.Show();
                         invPnl.BringToFront();break;
                     case Keys.K:
                         skill.Show();
                         skill.BringToFront(); break;
                     case Keys.L:
                         //Quest
                         break;
                     case Keys.Q:
                         qukPnl.Location = new Point(350, 650);
                         qukPnl.Show();
                         qukPnl.BringToFront();break;
                 }

             }
         }

         private void FormGame_Paint(object sender, PaintEventArgs e) {
             
         }

    }

    public class KeyMessageFilter : IMessageFilter {
        private enum KeyMessages {
            WM_KEYFIRST = 0x100,
            WM_KEYDOWN = 0x100,
            WM_KEYUP = 0x101,
            WM_CHAR = 0x102,
            WM_SYSKEYDOWN = 0x0104,
            WM_SYSKEYUP = 0x0105,
            WM_SYSCHAR = 0x0106,
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetParent(IntPtr hwnd);

        Control _control;

        public KeyMessageFilter() { }

        public KeyMessageFilter(Control c) {
            _control = c;
        }

        public bool PreFilterMessage(ref Message m) {
            if (m.Msg == (int)KeyMessages.WM_KEYDOWN) {
                if (_control != null) {
                    IntPtr hwnd = m.HWnd;
                    IntPtr handle = _control.Handle;
                    while (hwnd != IntPtr.Zero && handle != hwnd) {
                        hwnd = GetParent(hwnd);
                    }
                    if (hwnd == IntPtr.Zero) 
                        return false;
                }
                Keys key = (Keys)m.WParam;
                FormGame f;
                f = (FormGame)_control;
                f.KeyProcessing((int)key);
            }
            return false;
        }
    }
}


