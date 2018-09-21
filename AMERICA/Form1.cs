using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace AMERICA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush redBrush = new SolidBrush(Color.DarkRed);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Pen whitePen = new Pen(Color.White, 5);

            g.Clear(Color.Black);

            //back of flag 
            g.FillRectangle(whiteBrush, 50, 100, 240, 130);

            //stripes
            g.FillRectangle(redBrush, 50, 100, 240, 10);
            g.FillRectangle(redBrush, 50, 120, 240, 10);
            g.FillRectangle(redBrush, 50, 140, 240, 10);
            g.FillRectangle(redBrush, 50, 160, 240, 10);
            g.FillRectangle(redBrush, 50, 180, 240, 10);
            g.FillRectangle(redBrush, 50, 200, 240, 10);
            g.FillRectangle(redBrush, 50, 220, 240, 10);

            //starbox
            g.FillRectangle(blueBrush, 50, 100, 100, 60);
        }
    }
}
