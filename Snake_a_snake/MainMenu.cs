﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Snake_a_snake
{
    public partial class MainMenu : Form
    {
        SnakeControl Snakes;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {/*
            Bitmap b = new Bitmap(300, 400);
            Graphics g = Graphics.FromImage(b);
            g.DrawRectangle(Pens.Black, 0, 0, 20, 20);
            pictureBoxSnake1.Image = b;
            SolidBrush brush = new SolidBrush(Color.DarkBlue);*/
            
            Snakes.DrawLeftSnake();
            this.KeyDown += Snakes.LeftSnakeControl;
            this.Focus();
            /*
            Thread temp = new Thread(snakes.StartLeftSnake);
            temp.Start();*/
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

            Bitmap a = new Bitmap(300, 400);
            Bitmap b = new Bitmap(300, 400);
            pictureBoxSnake1.Image = a;
            pictureBoxSnake2.Image = b;

            int SpeedLeft = (int)numericUpDownSpeed1.Value;
            int SpeedRight = (int)numericUpDownSpeed2.Value;
            Snakes = new SnakeControl(pictureBoxSnake1, pictureBoxSnake2, SpeedLeft, SpeedRight);

        }

        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
           // Snakes.LeftSnakeControl(sender, e);
        }
    }
}
