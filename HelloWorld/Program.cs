using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(String[] args)
        {
            // WriteLine
            Console.WriteLine("Hello, World!!!");
            Console.WriteLine("Again");

            // ReadLine
            Console.Write("Whats Your Name? ");
            string? name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");
        }
    }
}