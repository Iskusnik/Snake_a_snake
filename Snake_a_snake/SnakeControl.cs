using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Snake_a_snake
{
    
    //Bitmap snake;
    class SnakeControl
    {
        public static Pen GreenPen = new Pen(Color.ForestGreen, 5);
        public static Pen BlackPen = new Pen(Color.Black, 3);
        public static TextureBrush SnakeBody = new TextureBrush(Image.FromFile(@"C:\Users\IskusnikXD\Source\Repos\Snake_a_snake\Snake_a_snake\LEATHERSNAKE.jpeg"));
        public static TextureBrush SnakeHead = new TextureBrush(Image.FromFile(@"C:\Users\IskusnikXD\Source\Repos\Snake_a_snake\Snake_a_snake\SNAKEHEAD.jpeg"));

        PictureBox LeftPicture, RightPicture;
        Snake LSnake, RSnake;
        public enum Move { Up = 0, Down = 1, Left = 2, Right = 3};
        public SnakeControl(PictureBox leftField, PictureBox rightField)
        {
            LeftPicture = leftField;
            RightPicture = rightField;
            LSnake = new Snake();
           // LSnake
        }
        public void LeftSnakeControl(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.W) ;
            if (e.KeyData == Keys.A) ;
            if (e.KeyData == Keys.S) ;
            if (e.KeyData == Keys.D) ;
            
        }

        #region Отображение
        static Bitmap DrawSnake(Bitmap bitmap, Snake snake)
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
        }
        #endregion

    }

    class Snake
    {

        static int width = 20;

        public List<SnakeSegment> Body;
        
        public Snake()
        {
            int x = 40;
            int y = 40;

            Body = new List<SnakeSegment>(100);

            for (int i = 0; i < 5; i++)
                Body.Add(new SnakeSegment(x, y + i * 20, width));
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
            Segment.Y--;
        }
        public void Left()
        {
            Segment.X--;
        }
        public void Down()
        {
            Segment.Y++;
        }
        public void Right()
        {
            Segment.X++;
        }
    }
}
