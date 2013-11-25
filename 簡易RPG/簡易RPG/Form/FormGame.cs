using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RPGControl;
using System.Runtime.InteropServices;

namespace 簡易RPG
{
    public partial class FormGame : System.Windows.Forms.Form
    {
        
        public const int SizeX = 1000;
        public const int SizeY = 700;

        Map map=new Map();
        Player ply = new Player();
        NPC npc = new NPC(false);
        EscPanel Esc = new EscPanel();
        skillPanel skill = new skillPanel();
        rolePanel rolePnl = new rolePanel();
        quickSlotPanel qukPnl = new quickSlotPanel();
        InventoryPanel invPnl = new InventoryPanel();
        KeyMessageFilter filter;


        public FormGame() {
            InitializeComponent();
            filter = new KeyMessageFilter(this);
            // add the filter
            Application.AddMessageFilter(filter);


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

            map.create();
            for (int i = 0; i < 14; ++i) {
                for (int j = 0; j < 20; ++j) {
                    this.Controls.Add(map.pic[i, j]);
                }
            }
            ply.loadPly();
            this.Controls.Add(ply.pic);
            ply.pic.BringToFront();
            this.Controls.Add(npc.pic);
            npc.pic.BringToFront();

        }

        #region
        int keycode;
        const int KEYDOWN = 0x100;
        const int KEY_LEFT = 37;
        const int KEY_DOWN = 40;
        const int KEY_ESC  = 27;
        const int KEY_C    = 99;
        const int KEY_D    = 100;
        #endregion

        protected override void WndProc(ref Message m) {
            if(m.Msg == KEYDOWN) {
                keycode = (int)m.WParam;
            }
            base.WndProc(ref m);
        }

         public void move(int code){

             bool mapMove = true;
             if(code == 37 && ply.getLocX > 500) {
                     mapMove = false;
             }else if(code==38 && ply.getLocY > 350){
                     mapMove = false;
             }else if(code==39 && ply.getLocX < 500){
                     mapMove = false;
             } else if (code == 40 && ply.getLocY < 350) {
                 mapMove = false;
             }
             if (mapMove && !map.move(code - 37) || (!mapMove)) {
                 ply.move(code);
             }
        }

         public void KeyProcessing(int keycode) {
             if (keycode >= 37 && keycode <= 40) {
                 move(keycode);
             } else if (keycode >> 4 == 3) {

             } else {
                 switch (keycode) {
                     case KEY_ESC:
                         Esc.Location = new Point(400, 300);
                         Esc.Show();
                         Esc.BringToFront();break;
                     case (int)Keys.C:
                         rolePnl.Show();
                         rolePnl.BringToFront();break;
                     case (int)Keys.D:
                         break;
                     case (int)Keys.I:
                         invPnl.Show();
                         invPnl.BringToFront();break;
                     case (int)Keys.K:
                         skill.Show();
                         skill.BringToFront(); break;
                     case (int)Keys.L:
                         //Quest
                         break;
                     case (int)Keys.Q:
                         qukPnl.Location = new Point(350, 650);
                         qukPnl.Show();
                         qukPnl.BringToFront();break;
                 }

             }
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
                    if (hwnd == IntPtr.Zero) // Didn't found the window. We are not interested in the event.
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


