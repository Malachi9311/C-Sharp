using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal()
            {
                Name = "Garfield",
                Sound = "Meow"
            };

            Dog dog = new Dog()
            {
                Name = "Jake",
                Sound = "Woof"
            };

            cat.MakeSound();
            dog.MakeSound();
        }
    }
}