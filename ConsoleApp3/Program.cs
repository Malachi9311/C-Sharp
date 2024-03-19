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

            cat.SetAnimalIDInfo(12345, "Mera");
            dog.SetAnimalIDInfo(67890, "Malachi");

            cat.GetAnimalIDInfo();
            dog.GetAnimalIDInfo();

            Animal.AnimalHealth healthy = new Animal.AnimalHealth();

            System.Console.WriteLine("this animal is healthy: {0}", healthy.HealthyWeight(11, 46));
        }
    }
}