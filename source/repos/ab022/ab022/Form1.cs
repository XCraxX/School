using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ab022
{
    
    public partial class Form1 : Form
    {
        
        int punkte = 0;
        bool toleft, toright, goup, godown;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timLauf.Enabled = true;
            toleft = true;
            godown = true;
        }

        private void timLauf_Tick(object sender, EventArgs e)
        {
            if (picPuk.Location.X + picPuk.Width >= picSpiel.Location.X)
            {
                for(int i = 0; i<= picSpiel.Height; i++)
                {
                    if (picPuk.Location.Y + i == picSpiel.Location.Y)
                    {
                        punkte = +10;
                        txtPoint.Text = Convert.ToString(punkte);
                    }
                }                
            }

            if (picPuk.Location.X + picPuk.Width > pnlFeld.Width)
            {
                toleft = true;
                toright = false;
            }
            if (picPuk.Location.X < pnlFeld.Location.X)
            {
                toleft = false;
                toright = true;
            }

            if (picPuk.Location.Y + picPuk.Height > pnlFeld.Height)
            {
                goup = true;
                godown = false;
            }
            if (picPuk.Location.Y < pnlFeld.Location.Y)
            {
                goup = false;
                godown = true;
            }

            if (timLauf.Enabled)
            {
                if (toleft)
                {
                    int newx = picPuk.Location.X - 5;
                    picPuk.Location = new Point(newx, picPuk.Location.Y);
                }
                if (toright)
                {
                    int newx = picPuk.Location.X + 5;
                    picPuk.Location = new Point(newx, picPuk.Location.Y);
                }
                if (godown)
                {
                    int newy = picPuk.Location.Y + 5;
                    picPuk.Location = new Point(picPuk.Location.X, newy);
                }
                if (goup)
                {
                    int newy = picPuk.Location.Y - 5;
                    picPuk.Location = new Point(picPuk.Location.X, newy);
                }
            }
        }

        private void vsbSpiel_Scroll(object sender, ScrollEventArgs e)
        {
            int y = vsbSpiel.Value;
            int yy = (pnlFeld.Height / 100) * y;
            picSpiel.Location = new Point(picSpiel.Location.X, yy);          
        }
    }
}
