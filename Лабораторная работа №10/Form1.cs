using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Point[] points = new Point[50];
        private void blackPen(Graphics g)
        {
            Pen blackPen = new Pen(Color.Black, 3);
            int x1 = 100;
            int y1 = 100;
            int x2 = 500;
            int y2 = 100;
            g.DrawLine(blackPen, x1, y1, x2, y2);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        { 
            Graphics g = e.Graphics;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
