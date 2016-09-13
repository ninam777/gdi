using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektovanjeKuca
{
    public partial class Form1 : Form
    {
        bool crtanje;
        SolidBrush boja;
        int x, y, lx, ly = 0;
        Item currItem;

        public enum Item
        {
            Prostorija, Prozor, Vrata, Sanitarija, Stepeniste
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pbProstorija_MouseClick(object sender, MouseEventArgs e)
        {
            //currItem = Item.Prostorija;
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            currItem = Item.Prostorija;
        }

        private void radnaPovrsina_MouseUp(object sender, MouseEventArgs e)
        {
            crtanje = false;
            lx = e.X;
            ly = e.X;

            if (currItem == Item.Prostorija)
            {
                Graphics g = radnaPovrsina.CreateGraphics();
                boja = new SolidBrush(Color.Black);
                g.DrawRectangle(new Pen(Color.Black), x, y, e.X - x, e.Y - y);
                g.Dispose();
            }
        }

        private void radnaPovrsina_MouseDown(object sender, MouseEventArgs e)
        {
            crtanje = true;
            x = e.X;
            y = e.X;

            
        }

        private void radnaPovrsina_MouseMove(object sender, MouseEventArgs e)
        {
            if (crtanje)
            {
                //Graphics g = radnaPovrsina.CreateGraphics();
                //boja = new SolidBrush(Color.Black);
                //g.DrawRectangle(new Pen(Color.Black), x, y, e.X, e.Y);
                //g.Dispose();
            }
        }
    }
}
