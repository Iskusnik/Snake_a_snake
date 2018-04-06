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
        
        public delegate void ChangeScore(int l, int r);
        //IAsyncResult Game;
        public void RefreshTextBox(int l, int r)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ChangeScore(RefreshTextBox), l, r);
                return;
            }
            else
            {
                textBoxScore1.Text = l.ToString();
                textBoxScore2.Text = r.ToString();
                textBoxSumScore.Text = (l + r).ToString();
            }
        }
        
        SnakeControl Snakes;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            numericUpDownSpeed1.Enabled = false;
            numericUpDownSpeed2.Enabled = false;
            LeftMaxLenght.Enabled = false;
            RightMaxLenght.Enabled = false;


            int SpeedLeft  = 2*(int)numericUpDownSpeed1.Value;
            int SpeedRight = 2*(int)numericUpDownSpeed2.Value;

            int LengthLeft = (int)LeftMaxLenght.Value;
            int LengthRight = (int)RightMaxLenght.Value;

            Snakes = new SnakeControl(pictureBoxSnake1, pictureBoxSnake2, SpeedLeft, SpeedRight, LengthLeft, LengthRight);
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
            
            Thread rightFood = new Thread(Snakes.MakeRightFood);
            rightFood.Name = "Еда для правой змеи";
            rightFood.IsBackground = true;
            rightFood.Priority = ThreadPriority.Highest;
            rightFood.Start();
            
            Thread ScoreControl = new Thread(CountScore);
            ScoreControl.Name = "Подсчёт";
            ScoreControl.IsBackground = true;
            ScoreControl.Priority = ThreadPriority.Lowest;
            ScoreControl.Start(new TextBox[] { textBoxScore1, textBoxScore2, textBoxSumScore });
            
        }
        private void CountScore(object info)
        {

            int left;
            int right;
            //ChangeScore chScore = new ChangeScore(RefreshTextBox);
            while (SnakeControl.ok)
            {
                left = Snakes.lScore;
                right = Snakes.rScore;
                Thread.Sleep(1000);
                RefreshTextBox(left, right);
            }
            Thread.CurrentThread.Abort();
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
            buttonStart.Enabled = true;
            numericUpDownSpeed1.Enabled = true;
            numericUpDownSpeed2.Enabled = true;
            LeftMaxLenght.Enabled = true;
            RightMaxLenght.Enabled = true;


            pictureBoxSnake1.Refresh();
            pictureBoxSnake2.Refresh();

            SnakeControl.ok = false;
        }

        private void numericUpDownSpeed1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
