﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch11
{
    public partial class Form3 : Form
    {
        private Graphics graphics;
        Rectangle myRect = new Rectangle();

        Brush blueBrush = new SolidBrush(Color.Blue);
        Pen blackPen = new Pen(Color.Black);

        public Form3()
        {
            InitializeComponent();

            graphics = this.CreateGraphics();
            myRect.X = 360;
            myRect.Y = 10;

            myRect.Width = 10;
            myRect.Height = 10;

            graphics.DrawRectangle(blackPen, myRect);
            graphics.FillRectangle(blueBrush, myRect);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Console.WriteLine("OnPaint!!!");
            graphics.DrawRectangle(blackPen, myRect);
            graphics.FillRectangle(blueBrush, myRect);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Brush redBrush = new SolidBrush(Color.Red);
            Pen blackPen = new Pen(Color.Black);

            Rectangle rect = new Rectangle(10, 10, 100, 100);

            // 도형그리기
            g.DrawRectangle(blackPen, rect);

            // 색 채우기
            g.FillRectangle(redBrush, rect);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen blackPen = new Pen(Color.Black);

            // 선 그리기
            g.DrawLine(blackPen, new Point(10, 120), new Point(200, 120 ));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Brush GreenBrush = new SolidBrush(Color.Green);
            Pen blackPen = new Pen(Color.Black);

            Rectangle rect = new Rectangle(120, 10, 100, 100);

            g.DrawEllipse(blackPen, rect);
            g.FillEllipse(GreenBrush, rect);
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("myTimer!!!");
            myRect.Y += 10;

            Invalidate();
        }
    }
}
