using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Snake_a_snake
{
    public partial class MainMenu : Form
    {
        //public delegate void Artist(object info);

        SnakeControl Snakes;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            //Snakes.DrawLeftSnake();

            /*Artist artist = new Artist(Snakes.StartLeftSnake);
            IAsyncResult temp = artist.BeginInvoke(null, null, null);
            artist.EndInvoke(temp);*/

            //System.Threading.Timer timer = new System.Threading.Timer(Snakes.StartLeftSnake, null, 0, Snakes.LeftSpeed);

            pictureBoxSnake1.Refresh();
            pictureBoxSnake2.Refresh();

            int SpeedLeft  = 3*(int)numericUpDownSpeed1.Value;
            int SpeedRight = 3*(int)numericUpDownSpeed2.Value;
            Snakes = new SnakeControl(pictureBoxSnake1, pictureBoxSnake2, SpeedLeft, SpeedRight);
            SnakeControl.ok = true;

            this.KeyDown += Snakes.LeftSnakeControl;
            this.KeyDown += Snakes.RightSnakeControl;

            Thread left = new Thread(Snakes.StartLeftSnake);
            left.Name = "Прорисовка левой змеи";
            left.IsBackground = true;
            left.Priority = ThreadPriority.Normal;
            left.Start();

            
            Thread leftFood = new Thread(Snakes.MakeLeftFood);
            leftFood.Name = "Еда для левой змеи";
            leftFood.IsBackground = true;
            leftFood.Priority = ThreadPriority.Highest;
            leftFood.Start();

            

            Thread right = new Thread(Snakes.StartRightSnake);
            right.Name = "Прорисовка правой змеи";
            right.IsBackground = true;
            right.Priority = ThreadPriority.Normal;
            right.Start();
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.Name = "Форма";
            GraphicsPath temp = new GraphicsPath();
            
            Bitmap a = new Bitmap(300, 400);
            Bitmap b = new Bitmap(300, 400);
            pictureBoxSnake1.Image = a;
            pictureBoxSnake2.Image = b;

            Thread.CurrentThread.Priority = ThreadPriority.Highest;
        }

        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
           // Snakes.LeftSnakeControl(sender, e);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            SnakeControl.ok = false;
        }
    }
}
