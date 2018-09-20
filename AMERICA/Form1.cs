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

            g.Clear(Color.White);

            g.FillRectangle(redBrush, 50, 100, 260, 160);
            g.FillRectangle(blueBrush, 50, 100, 100, 80);

            //stripes
            g.FillRectangle(whiteBrush, 125, 100, 75, 20);


        }
    }
}
