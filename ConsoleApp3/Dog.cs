using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Dog : Animal
    {
        private string sound2 = "";
        // Additional Properties.
        public string Sound2
        {
            get { return "Grrrr"; }
            set
            {
                sound2 = value;
            }
        }

        public override void MakeSound()
        {
            System.Console.WriteLine($"{Name} says {Sound} and {Sound2}.");
        }

        public Dog(string name = "No Name", string sound = "No Sound", string sound2 = "No Sound2")
            : base(name, sound)
        {
            Sound2 = sound2;
        }
    }
}