using System;
using System.Collections.Generic;
using System.Collections;
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
        public Label labBG = new Label();
        Map       map;
        Player    ply;
        NPC       npc     = new NPC(false);
        Monster[] monster = new Monster[4];

        //userControl
        EscPanel       EscPnl   = new EscPanel();
        skillPanel     skillPnl = new skillPanel();
        rolePanel      rolePnl  = new rolePanel();
        quickSlotPanel qukPnl   = new quickSlotPanel();
        InventoryPanel invPnl   = new InventoryPanel();

        //System
        BattleSystem     BS;

        //Application
        KeyMessageFilter filter;

        //Function
        public FormGame(Player rply) {
            InitializeComponent();
            BS     = new BattleSystem(this);
            filter = new KeyMessageFilter(this);
            Application.AddMessageFilter(filter);

            ply = rply;
            rolePnl.loadNum(ply.numerical.name, ply.numerical.lv, ply.numerical.hp, ply.numerical.sp, ply.numerical.hp, ply.numerical.sp, ply.numerical.atk, ply.numerical.def, 0, 0, 0, 0);
            InitObject();  
        }

        void InitObject() {

            labBG.Size = new Size(1000, 700); 
            labBG.Visible = true;
            this.Controls.Add(labBG);

            ply.loadPly();
            this.Controls.Add(ply.pic);
            this.Controls.Add(npc.pic);

            map = new Map();
            map.create(labBG);
            map.setCamera(ply.pic);
            map.addOrganPic(npc);
           
            ply.pic.BringToFront();
            npc.pic.BringToFront();
            
            for (int i = 0 ; i < 4 ; ++i) {
                monster[i] = new Monster("mon" + i);
                this.Controls.Add(monster[i].pic);
                map.addOrganPic(monster[i]);
                monster[i].pic.BringToFront();
            }

            EscPnl  .Visible = false;
            rolePnl .Visible = false;
            skillPnl.Visible = false;
            qukPnl  .Visible = false;
            invPnl  .Visible = false;
            this.Controls.Add(EscPnl);
            this.Controls.Add(rolePnl);
            this.Controls.Add(skillPnl);
            this.Controls.Add(qukPnl);
            this.Controls.Add(invPnl);
        }

        private void FormGame_Load(object sender, EventArgs e) {
            
        }

        public void move(int code) {
            ply.move(code - 37);
            ply.picMove(code - 37);
            map.move(code - 37);
        }

        public void KeyProcessing(int keycode) {
            if (keycode >= 37 && keycode <= 40) {
                move(keycode);
            } else if (keycode >> 4 == 3) {

            } else {
                switch ((Keys)keycode) {
                    case Keys.Escape:
                        EscPnl.Location = new Point(400, 300);
                        EscPnl.Show();
                        EscPnl.BringToFront(); break;
                    case Keys.A:
                        //error
                        Queue qu = map.searchMatrixObj(1, ply.loc.x, ply.loc.y);
                        BS.Batttle(ply, qu);
                        break;
                    case Keys.C:
                        rolePnl.Show();
                        rolePnl.BringToFront(); break;
                    case Keys.D:
                        break;
                    case Keys.I:
                        invPnl.Show();
                        invPnl.BringToFront(); break;
                    case Keys.K:
                        skillPnl.Show();
                        skillPnl.BringToFront(); break;
                    case Keys.L:
                        //Quest
                        break;
                    case Keys.Q:
                        qukPnl.Location = new Point(350, 650);
                        qukPnl.Show();
                        qukPnl.BringToFront(); break;
                }

            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e) {
            base.OnFormClosed(e);
            Application.Exit();
        }
    }

    public class KeyMessageFilter : IMessageFilter {
        private enum KeyMessages {
            WM_KEYFIRST   = 0x100,
            WM_KEYDOWN    = 0x100,
            WM_KEYUP      = 0x101,
            WM_CHAR       = 0x102,
            WM_SYSKEYDOWN = 0x0104,
            WM_SYSKEYUP   = 0x0105,
            WM_SYSCHAR    = 0x0106,
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

