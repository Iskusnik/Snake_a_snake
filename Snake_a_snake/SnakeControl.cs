using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Timers;

namespace Snake_a_snake
{
    class SnakeControl
    {

        public static AutoResetEvent waitHandleLEFT = new AutoResetEvent(false);
        public static AutoResetEvent waitHandleRIGHT = new AutoResetEvent(false);

        public static Pen GreenPen = new Pen(Color.ForestGreen, 0);
        public static Pen BlackPen = new Pen(Color.Black, 0);
        //public static TextureBrush SnakeBody = new TextureBrush(Image.FromFile(@"C:\Users\IskusnikXD\Source\Repos\Snake_a_snake\Snake_a_snake\LEATHERSNAKE.jpeg"));
        //public static TextureBrush SnakeHead = new TextureBrush(Image.FromFile(@"C:\Users\IskusnikXD\Source\Repos\Snake_a_snake\Snake_a_snake\SNAKEHEAD.jpeg"));
        public static TextureBrush SnakeBody = new TextureBrush(Image.FromFile(@"LEATHERSNAKE.jpeg"));
        public static TextureBrush SnakeHead = new TextureBrush(Image.FromFile(@"SNAKEHEAD.jpeg"));
        public int LeftSpeed, RightSpeed;
        PictureBox LeftPicture, RightPicture;
        Snake LSnake, RSnake;
        public static bool ok = true;
        public int lScore, rScore;
        public SnakeControl(PictureBox leftField, PictureBox rightField, int SpeedLeft, int SpeedRight, int LengthLeft, int LengthRight)
        {
            lScore = 0;
            rScore = 0;

            LeftPicture = leftField;
            RightPicture = rightField;
            LSnake = new Snake(LengthLeft);
            RSnake = new Snake(LengthRight);

            LeftSpeed = 1000;
            RightSpeed = 1000;

            LeftSpeed /= SpeedLeft;
            RightSpeed /= SpeedRight;
        }


        #region Отображение
        static object LockMarker = new object();
        static PictureBox DrawSnake(PictureBox pictureBox, Snake snake)
        {
            lock(LockMarker)
            {
                Graphics draw = pictureBox.CreateGraphics();

                draw.DrawRectangle(GreenPen, snake.Body[0].Segment);
                draw.FillRectangle(SnakeHead, snake.Body[0].Segment);

                for (int i = 1; i < snake.Body.Count; i++)
                {
                    draw.DrawRectangle(BlackPen, snake.Body[i].Segment);
                    draw.FillRectangle(SnakeBody, snake.Body[i].Segment);
                }

                draw.FillRectangle(Brushes.Crimson, snake.Food.Segment);

                draw.Dispose();
                return pictureBox;
            }
        }
        static PictureBox EraseSnake(PictureBox pictureBox, Snake snake)
        {
            lock (LockMarker)
            {
                Graphics draw = pictureBox.CreateGraphics();

                draw.DrawRectangle(Pens.White, snake.Body[snake.Body.Count - 1].Segment);
                draw.FillRectangle(Brushes.White, snake.Body[snake.Body.Count - 1].Segment);
                draw.Dispose();
                return pictureBox;
            }
        }
        
        #region
        public void DrawLeftSnake()
        {
            LeftPicture = DrawSnake(LeftPicture, LSnake);
        }
        public void DrawRightSnake()
        {
            RightPicture = DrawSnake(RightPicture, RSnake);
        }
        public void EraseLeftSnake()
        {
            LeftPicture = EraseSnake(LeftPicture, LSnake);
        }
        public void EraseRightSnake()
        {
            RightPicture = EraseSnake(RightPicture, RSnake);
        }
        #endregion
        #endregion
        #region Обработка ввода клавиш
        public void LeftSnakeControl(object sender, KeyEventArgs e)
        {


            if (e.KeyData == Keys.W && LSnake.Way != (int)Snake.Direction.Down)
                LSnake.tempWay = (int)Snake.Direction.Up;

            if (e.KeyData == Keys.A && LSnake.Way != (int)Snake.Direction.Right)
                LSnake.tempWay = (int)Snake.Direction.Left;

            if (e.KeyData == Keys.S && LSnake.Way != (int)Snake.Direction.Up)
                LSnake.tempWay = (int)Snake.Direction.Down;

            if (e.KeyData == Keys.D && LSnake.Way != (int)Snake.Direction.Left)
                LSnake.tempWay = (int)Snake.Direction.Right;

            
            // StartLeftSnake(null);
        }

        public void RightSnakeControl(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up && RSnake.Way != (int)Snake.Direction.Down)
                RSnake.tempWay = (int)Snake.Direction.Up;

            if (e.KeyData == Keys.Left && RSnake.Way != (int)Snake.Direction.Right)
                RSnake.tempWay = (int)Snake.Direction.Left;

            if (e.KeyData == Keys.Down && RSnake.Way != (int)Snake.Direction.Up)
                RSnake.tempWay = (int)Snake.Direction.Down;

            if (e.KeyData == Keys.Right && RSnake.Way != (int)Snake.Direction.Left)
                RSnake.tempWay = (int)Snake.Direction.Right;
            // StartRightSnake(null);
        }
        #endregion
        #region Поток
        public void StartLeftSnake(object data)
        {
            

            while (ok)
            {
                Thread.Sleep(LeftSpeed);
                EraseLeftSnake();
                LSnake.Move();
                if (LSnake.Full)
                {
                    SnakeControl.waitHandleLEFT.Set();
                    lScore += LSnake.Body.Count * 1000 / LeftSpeed;
                    SnakeControl.waitHandleLEFT.WaitOne();
                }
                DrawLeftSnake();
            }

            Thread.CurrentThread.Abort();
        }
        public void StartRightSnake(object data)
        {
            
            while (ok)
            {
                Thread.Sleep(RightSpeed);
                EraseRightSnake();
                RSnake.Move();
                if (RSnake.Full)
                {
                    SnakeControl.waitHandleRIGHT.Set();
                    rScore += RSnake.Body.Count * 1000 / RightSpeed;
                    SnakeControl.waitHandleRIGHT.WaitOne();
                }
                DrawRightSnake();
            }

            MessageBox.Show(string.Format("Счёт: {0}", lScore + rScore), "Конец");
            Thread.CurrentThread.Abort();
        }

        public void MakeLeftFood()
        {
            while (ok)
            {
                SnakeControl.waitHandleLEFT.WaitOne();
                LSnake.Food = new SnakeFood(LSnake, 20);
                SnakeControl.waitHandleLEFT.Set();
            }
            Thread.CurrentThread.Abort();
        }
        public void MakeRightFood()
        {
            while (ok)
            {
                SnakeControl.waitHandleRIGHT.WaitOne();
                RSnake.Food = new SnakeFood(RSnake, 20);
                SnakeControl.waitHandleRIGHT.Set();
            }
            Thread.CurrentThread.Abort();
        }

        #endregion
    }

    
}

//1. Обработка KeyEvent (нажатие кнопки): 
//1.1 - изменение направления, 
//1.2 - проверка на столкновения, 
//1.3 - проверка на скушанье,
//1.4 - увеличение роста.

//Загнать в цикл???
//System.Timers.Timer timer = new System.Timers.Timer(100 / (int)form.numericUpDownSpeed1.Value);
//timer.Elapsed+=
//2. Таймер (?): 2.1. Истёк. 2.2. Движение.

//3. Стереть старую змейку.
//4. Нарисовать новую.
/* while (true)
 { 
     Thread.Sleep(LeftSpeed);
     EraseLeftSnake();
     LSnake.Move();
     DrawLeftSnake();
 }*/

//System.Timers.Timer timer = new System.Timers.Timer(LeftSpeed);
//timer.Elapsed += EraseLeftSnake(object sender, KeyEventArgs e);
/*BITMAP - плохо
 * 
 * SnakeControl.waitHandle.WaitOne();
            SnakeControl.waitHandle.Set();
 * static Bitmap DrawSnake(Bitmap bitmap, Snake snake)
        {
            Graphics draw = Graphics.FromImage(bitmap);

            draw.DrawRectangle(GreenPen, snake.Body[0].Segment);
            draw.FillRectangle(SnakeHead, snake.Body[0].Segment);

            for (int i = 1; i < snake.Body.Count; i++)
            {
                draw.DrawRectangle(BlackPen, snake.Body[i].Segment);
                draw.FillRectangle(SnakeBody, snake.Body[i].Segment);
            }
            draw.Dispose();
            return bitmap;
        }
        static Bitmap EraseSnake(Bitmap bitmap, Snake snake)
        {
            Graphics draw = Graphics.FromImage(bitmap);

            draw.DrawRectangle(Pens.White, snake.Body[snake.Body.Count - 1].Segment);
            draw.FillRectangle(Brushes.White, snake.Body[snake.Body.Count - 1].Segment);
            draw.Dispose();
            return bitmap;

        }

        public void DrawLeftSnake()
        {
            LeftPicture.Image = DrawSnake(new Bitmap(LeftPicture.Image), LSnake);
        }
        public void DrawRightSnake()
        {
            RightPicture.Image = DrawSnake(new Bitmap(RightPicture.Image), RSnake);
        }
        public void EraseLeftSnake()
        {
            LeftPicture.Image = EraseSnake(new Bitmap(LeftPicture.Image), LSnake);
        }
        public void EraseRightSnake()
        {
            RightPicture.Image = EraseSnake(new Bitmap(RightPicture.Image), RSnake);
        }*/
