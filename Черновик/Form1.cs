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

namespace Черновик
{
    public partial class Form1 : Form
    {
        public ArtTools.SnakeControl Snakes;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.Name = "Форма";

            Bitmap a = new Bitmap(300, 400);
            pictureBox1.Image = a;
            Snakes = new ArtTools.SnakeControl(pictureBox1, null, 1, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.KeyDown += Snakes.LeftSnakeControl;

            Thread temp = new Thread(Snakes.StartLeftSnake);
            temp.Name = "Управление";
            temp.IsBackground = true;
            temp.Start();
        }
    }
}
