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
            // System.Console.Write("Whats Your Name? ");
            // string? name = Console.ReadLine();
            // System.Console.WriteLine($"Hello, {name}");
            System.Console.WriteLine("-----------------");
            // int & long
            // System.Console.WriteLine("byte range: {0}", byte.MaxValue);
            // System.Console.WriteLine("integer range: {0}", int.MaxValue);
            // System.Console.WriteLine("-----------------");
            // System.Console.WriteLine("short range: {0}", short.MaxValue);
            // System.Console.WriteLine("long range: {0}", long.MaxValue);
            // System.Console.WriteLine("-----------------");
            // System.Console.WriteLine("decimal range: {0}", decimal.MaxValue);
            // System.Console.WriteLine("float range: {0}", float.MaxValue.ToString("#"));
            // System.Console.WriteLine("-----------------");

            string[] strArray = { "ntuthuko", "nsika", "malachi", "Tass", "Myguy" };
            System.Console.WriteLine(strArray);
            // System.Console.WriteLine(strArray[0]);
            // System.Console.WriteLine(strArray.GetType());
            // System.Console.WriteLine(strArray[0].GetType());

            for (int i = 0; i < strArray.Length; i++)
            {
                System.Console.Write("{0}:{1}, ", i, strArray[i]);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("-----------------");
        }
    }
}