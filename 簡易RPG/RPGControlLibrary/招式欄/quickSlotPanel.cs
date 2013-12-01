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
    public partial class quickSlotPanel: UserControl
    {
        public quickSlotPanel()
        {
            InitializeComponent();
        }

        private void labExit_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void quickSlotPanel_Load(object sender, EventArgs e) {

        }

        bool isMouseDown;
        int locDX, locDY;
        private void quickSlotPanel_MouseDown(object sender, MouseEventArgs e) {
            this.BringToFront();
            isMouseDown = true;
            locDX = e.X;
            locDY = e.Y;
        }

        private void quickSlotPanel_MouseUp(object sender, MouseEventArgs e) {
            isMouseDown = false;
        }

        private void quickSlotPanel_MouseMove(object sender, MouseEventArgs e) {
            if (isMouseDown) {
                int x = e.X - locDX;
                int y = e.Y - locDY;
                this.Location = new Point(this.Location.X + x, this.Location.Y + y);
            }
        }

 


    }
}
