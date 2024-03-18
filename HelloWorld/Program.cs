using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(String[] args)
        {
            // WriteLine
            System.Console.WriteLine("Hello, World!!!");
            System.Console.WriteLine("Again");

            // ReadLine
            System.Console.Write("Whats Your Name? ");
            string? name = Console.ReadLine();
            System.Console.WriteLine($"Hello, {name}");
            System.Console.WriteLine("-----------------");
            // int & long
            System.Console.WriteLine($"Smallest integer {0}", int.MinValue);
            System.Console.WriteLine($"Smallest integer {0}", int.MaxValue);
            System.Console.WriteLine("-----------------");
            System.Console.WriteLine($"Smallest long {0}", long.MinValue);
            System.Console.WriteLine($"Smallest long {0}", long.MaxValue);
            System.Console.WriteLine("-----------------");
        }
    }
}