using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painter_Form
{
    public partial class Form1 : Form
    {

        bool shouldPaint = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint && Form1.MouseButtons == MouseButtons.Left)
            { 
                using (Graphics graphics = CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(Color.Black), e.X, e.Y, 4, 4);
                }
            }
            else if (shouldPaint && Form1.MouseButtons == MouseButtons.Right)
            {
                using (Graphics graphics = CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(Color.White), e.X, e.Y, 9, 9);
                }
            
            
            }
        }      


    }
}
