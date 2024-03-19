namespace ConsoleApp4
{
    // Class you don.t want to instantiate
    // are called Abstract classes.

    abstract class Shape
    {
        public string Name { get; set; } = "";

        public virtual void GetInfo()
        {
            System.Console.WriteLine($"This is a {Name}");
        }

        public abstract double Area();
    }
}