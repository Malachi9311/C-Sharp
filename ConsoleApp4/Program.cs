namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };

            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                System.Console.WriteLine("{0} -> Area: {1:f2}", shape.Name, shape.Area());
            }
        }
    }
}