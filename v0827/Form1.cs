using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0827
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        int a = Math.Abs(-10);
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            Point mp = MousePosition;
            mp = PointToClient(mp);
            label2.Left = mp.X;
            label2.Top = mp.Y;
            label2.Text = "" + mp.X + "," + mp.Y;

            if (label1.Left <= 0)
            {
                vx = Math.Abs(vx) * 11 / 10;
            }
            if (label1.Top <= 0)
            {
                vy = Math.Abs(vy) * 11 / 10;
            }
            if (label1.Right >= ClientSize.Width)
            {
                vx = -Math.Abs(vx) * 11 / 10;
            }
            if (label1.Top >= ClientSize.Height)
            {
                vy = -Math.Abs(vy) * 11 / 10;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
