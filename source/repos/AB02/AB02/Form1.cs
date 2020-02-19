using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AB02
{
    public partial class frmPingPong : Form
    {
        bool toleft, toright, goup, godown;
        public frmPingPong()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSpiel.Enabled = true;
            goup = true;
            toright = true;
        }

        private void tmrSpiel_Tick(object sender, EventArgs e)
        {
            if (picBall.Location.X + picBall.Width> pnlSpiel.Width)
            {
                toleft = true;
                toright = false;
            }
            if (picBall.Location.X < pnlSpiel.Location.X)
            {
                toleft = false;
                toright = true;
            }

            if (picBall.Location.Y + picBall.Height >  pnlSpiel.Height)
            {
                goup = true;
                godown = false;
            }
            if (picBall.Location.Y < pnlSpiel.Location.Y)
            {
                goup = false;
                godown = true;
            }

            if (tmrSpiel.Enabled)
            {
                if (toleft)
                {
                    int newx = picBall.Location.X - 5;
                    picBall.Location = new Point(newx, picBall.Location.Y);
                }
                if (toright)
                {
                    int newx = picBall.Location.X + 5;
                    picBall.Location = new Point(newx, picBall.Location.Y);
                }
                if (godown)
                {
                    int newy = picBall.Location.Y + 5;
                    picBall.Location = new Point(picBall.Location.X, newy);
                }
                if (goup)
                {
                    int newy = picBall.Location.Y - 5;
                    picBall.Location = new Point(picBall.Location.X, newy);
                }
            }
        }
    }
}
