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
    class Snake
    {

        static int width = 20;

        public enum Direction { Up = 0, Down = 1, Left = 2, Right = 3 };
        public int Way, tempWay;
        public List<SnakeSegment> Body;
        public SnakeFood Food;
        public bool Full;
        public int MaxLenght;

        public Snake()
        {
            int x = 40;
            int y = 40;
            Way = (int)Direction.Right;
            tempWay = Way;
            Body = new List<SnakeSegment>(100);

            for (int i = 0; i < 5; i++)
                Body.Add(new SnakeSegment(x, y + i * 20, width));

            Full = false;
            Food = new SnakeFood(200, 200, width);
        }
        public Snake(int Lenght) : this()
        {
            MaxLenght = Lenght;
        }

        public void Move()
        {
            int x = Body[Body.Count - 1].Segment.X;
            int y = Body[Body.Count - 1].Segment.Y;


            for (int i = Body.Count - 1; i > 0; i--)
            {
                Body[i].Segment.X = Body[i - 1].Segment.X;
                Body[i].Segment.Y = Body[i - 1].Segment.Y;
            }
            Way = tempWay;
            switch (Way)
            {
                case (int)Direction.Up: Body[0].Up(); break;
                case (int)Direction.Down: Body[0].Down(); break;
                case (int)Direction.Left: Body[0].Left(); break;
                case (int)Direction.Right: Body[0].Right(); break;
            }

            var collis = (from segm in Body where (segm.Segment.X == Body[0].Segment.X && segm.Segment.Y == Body[0].Segment.Y) select segm).ToList();
            if (collis.Count > 1)
                SnakeControl.ok = false;

            if (Full)
            {
                if (MaxLenght > Body.Count)
                    this.Grow(x, y);

                Full = false;
            }


            if (Food.Segment.X == Body[0].Segment.X && Food.Segment.Y == Body[0].Segment.Y)
            {
                Full = true;
            }
        }
        public void Grow(int x, int y)
        {
            Body.Add(new SnakeSegment(x, y, width));
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
    class SnakeFood
    {
        public Rectangle Segment;
        public enum Move { Up = 0, Down = 1, Left = 2, Right = 3 };
        static Random r = new Random();
        public SnakeFood(int x, int y, int w)
        {
            Segment = new Rectangle(x, y, w, w);
        }
        public SnakeFood(int w)
        {
            int x = r.Next(0, 20) * w;
            int y = r.Next(0, 15) * w;
            Segment = new Rectangle(x, y, w, w);
        }
        public SnakeFood(Snake snake, int w)
        {
            int x, y;
            do
            {
                x = r.Next(1, 15) * w;
                y = r.Next(1, 19) * w;
            }
            while ((from s in snake.Body where (s.Segment.X == x && s.Segment.Y == y) select s).Count() != 0);

            Segment = new Rectangle(x, y, w, w);
        }
    }
}
