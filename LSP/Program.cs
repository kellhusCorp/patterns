using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Rectangle
    {
        public virtual int Width { get; set; }

        public virtual int Height { get; set; }

        public Rectangle() { }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool IsSquare => Width == Height;

        public int Area => Width * Height;
    }

    public class Square : Rectangle
    {
        public Square(int side)
        {
            Width = Height = side;
        }

        public override int Height 
        { 
            set { base.Width = base.Height = value; }
        }

        public override int Width
        {
            set { base.Width = base.Height = value; }
        }
    }

    public class Demo
    {
        public static void UseIt(Rectangle r)
        {
            int width = r.Width;
            r.Height = 10;
            Console.WriteLine($"Expect area of {10 * width}," +
                $"got {r.Area}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var rc = new Rectangle(3, 2);
            Demo.UseIt(rc);
            var sq = new Square(5);
            Demo.UseIt(sq);
        }
    }
}
