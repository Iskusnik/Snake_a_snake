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

            int SpeedLeft  = (int)numericUpDownSpeed1.Value;
            int SpeedRight = (int)numericUpDownSpeed2.Value;
            Snakes = new SnakeControl(pictureBoxSnake1, pictureBoxSnake2, SpeedLeft, SpeedRight);

            this.KeyDown += Snakes.LeftSnakeControl;

            Thread temp = new Thread(Snakes.StartLeftSnake);
            temp.Name = "Управление";
            temp.IsBackground = true;
            temp.Priority = ThreadPriority.AboveNormal;
            temp.Start();
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
            Snakes.ok = false;
        }
    }
}
