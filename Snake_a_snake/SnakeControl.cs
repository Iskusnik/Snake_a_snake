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
    
    //Bitmap snake;
    class SnakeControl
    {

        public static AutoResetEvent waitHandle = new AutoResetEvent(false);

        public static Pen GreenPen = new Pen(Color.ForestGreen, 0);
        public static Pen BlackPen = new Pen(Color.Black, 0);
        public static TextureBrush SnakeBody = new TextureBrush(Image.FromFile(@"C:\Users\IskusnikXD\Source\Repos\Snake_a_snake\Snake_a_snake\LEATHERSNAKE.jpeg"));
        public static TextureBrush SnakeHead = new TextureBrush(Image.FromFile(@"C:\Users\IskusnikXD\Source\Repos\Snake_a_snake\Snake_a_snake\SNAKEHEAD.jpeg"));
        public int LeftSpeed, RightSpeed;
        PictureBox LeftPicture, RightPicture;
        Snake LSnake, RSnake;
        public bool ok = true;
        int Score;
        public SnakeControl(PictureBox leftField, PictureBox rightField, int SpeedLeft, int SpeedRight)
        {
            Score = 0;

            LeftPicture = leftField;
            RightPicture = rightField;
            LSnake = new Snake();
            RSnake = new Snake();

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

            while (ok)
            {
                Thread.Sleep(LeftSpeed);
                EraseLeftSnake();
                LSnake.Move();
                DrawLeftSnake();
               
            }
           
        }
        public void StartRightSnake(object data)
        {
            
            while (ok)
            {
                Thread.Sleep(RightSpeed);
                
                EraseRightSnake();
                RSnake.Move();
                DrawRightSnake();
            }
        }
        #endregion
    }

    class Snake
    {

        static int width = 20;

        public enum Direction { Up = 0, Down = 1, Left = 2, Right = 3 };
        public int Way, tempWay;
        public List<SnakeSegment> Body;
        
        public Snake()
        {
            int x = 40;
            int y = 40;
            Way = (int)Direction.Right;
            tempWay = Way;
            Body = new List<SnakeSegment>(100);

            for (int i = 0; i < 5; i++)
                Body.Add(new SnakeSegment(x, y + i * 20, width));
        }

        public void Move()
        {
            
            for (int i = Body.Count - 1; i > 0; i--)
            {
                Body[i].Segment.X = Body[i - 1].Segment.X;
                Body[i].Segment.Y = Body[i - 1].Segment.Y;
            }
            Way = tempWay;
            switch (Way)
            {
                case (int)Direction.Up:    Body[0].Up();    break;
                case (int)Direction.Down:  Body[0].Down();  break;
                case (int)Direction.Left:  Body[0].Left();  break;
                case (int)Direction.Right: Body[0].Right(); break;
            }
            
        }
             
    }

    class SnakeSegment
    {
        public Rectangle Segment;
        public enum Move { Up = 0, Down = 1, Left = 2, Right = 3 };

        public SnakeSegment(int x, int y, int w)
        {
            Segment = new Rectangle(x, y, w, w);
        }
        public void Up()
        {
            Segment.Y -= Segment.Width;
            if (Segment.Y < 0)
                Segment.Y = 380;
        }
        public void Left()
        {
            Segment.X -= Segment.Width;
            if (Segment.X < 0)
                Segment.X = 280;
        }
        public void Down()
        {
            Segment.Y += Segment.Width;
            if (Segment.Y >= 400)
                Segment.Y = 0;
        }
        public void Right()
        {
            Segment.X += Segment.Width;
            if (Segment.X >= 300)
                Segment.X = 0;
        }
    }
}
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
