using System.Drawing;

namespace consoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // double area = ShapeMath.GetArea("Rectangle", 2, 3);
            // System.Console.WriteLine("{0}", area);

            Rectangle rect;
            rect.length = 200;
            rect.width = 50;

            double area = rect.Area();
            System.Console.WriteLine("{0}", area);

            Rectangle rect1 = new Rectangle(100, 75);
            System.Console.WriteLine("{0}", rect1.Area().GetType().ToString());
        }

        struct Rectangle
        {
            // Fields / Attributes.
            public double length;
            public double width;

            // Constructor
            public Rectangle(double l = 1, double w = 1)
            {
                length = l;
                width = w;
            }
            // Method
            public double Area()
            {
                return length * width;
            }
        }
    }
}