namespace consoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = ShapeMath.GetArea("Rectangle", 2, 3);
            System.Console.WriteLine("{0}", area);
        }
    }
}