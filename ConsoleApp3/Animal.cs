using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Animal
    {
        private string name = "";
        protected string sound = "";

        protected AnimalIDInfo animalIDInfo = new AnimalIDInfo();

        public void SetAnimalIDInfo(int IDNum, string Owner)
        {
            animalIDInfo.IDNum = IDNum;
            animalIDInfo.Owner = Owner;
        }

        public void GetAnimalIDInfo()
        {
            System.Console.WriteLine($"{name} has the ID of {animalIDInfo.IDNum} and is owned by {animalIDInfo.Owner}");
        }

        public virtual void MakeSound()
        {
            System.Console.WriteLine($"{Name} say {Sound}");
        }

        public Animal() : this("No Name", "No Sound") { }

        public Animal(string name) : this(name, "No Sound") { }

        public Animal(string name, string sound)
        {
            string? Name = name;
            string? Sound = sound;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!name.Any(char.IsDigit))
                {
                    name = "No Name";
                }
                else
                {
                    name = value;
                }
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (!sound.Any(char.IsDigit))
                {
                    sound = "No Sound";
                }
                else
                {
                    sound = value;
                }
            }
        }

        public class AnimalHealth
        {
            public bool HealthyWeight(double weight, double height)
            {
                double calc = height / weight;
                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }
                return false;
            }
        }
    }
}