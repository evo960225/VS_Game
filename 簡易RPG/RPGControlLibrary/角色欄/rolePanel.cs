using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGControl
{
    public partial class rolePanel: UserControl
    {
        Numerical num=new Numerical();

        public rolePanel() {
            InitializeComponent();
        }

        private void butEnter_Click(object sender, EventArgs e) {
            this.Hide();   
        }

        private void labExit_Click(object sender, EventArgs e) {
            this.Hide();
        }

        bool isMouseDown;
        int locDX,locDY;
        private void labTitle_MouseDown(object sender, MouseEventArgs e) {
            isMouseDown = true;
            locDX = e.X;
            locDY = e.Y;
        }

        private void labTitle_MouseUp(object sender, MouseEventArgs e) {
            isMouseDown = false;
        }

        private void labTitle_MouseMove(object sender, MouseEventArgs e) {
            if (isMouseDown) {
                int x = e.X - locDX;
                int y = e.Y - locDY;
                this.Location = new Point(this.Location.X + x, this.Location.Y + y);
            }
        }

        public void labFormat() {
            labName.Text = num.name;
            labLv.Text = string.Format("{0,3}", num.lv);
            labHP.Text = string.Format("{0,-14}", num.maxHp) +
                string.Format("+{0,-12}", num.addHp) +
                string.Format("{0,4}", num.hp) + "/" + string.Format("{0,4}", num.maxHp + num.addHp);
            labSP.Text = string.Format("{0,-14}", num.maxSp) +
                string.Format("+{0,-12}", num.addSp) +
                string.Format("{0,4}", num.sp) + "/" + string.Format("{0,4}", num.maxSp + num.addSp);
            labAtk.Text = string.Format("{0,-14}", num.atk) +
                string.Format("+{0,-16}", num.addAtk) +
                string.Format("{0,4}", num.atk+num.addAtk);
            labDef.Text = string.Format("{0,-14}", num.def) +
                string.Format("+{0,-16}", num.addDef) +
                string.Format("{0,4}", num.def + num.addDef);
            
        }

        private void rolePanel_Load(object sender, EventArgs e) {
            labFormat();
        }

        public void loadNum(Numerical rn) {
            num = rn;
            labFormat();
        }
        public void loadNum(string na, int l, int h, int s, int mh, int ms, int at, int de, int ahp, int asp, int aat, int adf) {
            num = new Numerical(na, l, h, s, mh, ms, at, de, ahp, asp, aat, adf);
            labFormat();
        }

        private void labTitle_Click(object sender, EventArgs e) {
            
        }

        private void rolePanel_MouseDown(object sender, MouseEventArgs e) {
            this.BringToFront();
        }
    }
}
