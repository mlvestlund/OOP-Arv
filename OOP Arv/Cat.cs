using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Cat : Animal //a subclass to animal
    {
        public readonly bool HasSass = true; //unique attribute for cats with default value

        public Cat(string name, int age, bool domesticated, string color, int numberOfLegs, bool hasSass) : base(name, age, domesticated, color, numberOfLegs)
        {
            HasSass = hasSass;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"*{Name} säger: mjau mjau purr*");
        }

        public void ActSassy() //unique method for cats
        {
            if (HasSass)
            {
                Console.WriteLine($"*{Name} beter sig sassy*");
            }
            else
            {
                Console.WriteLine($"Error: Är du säker på att det är en katt??");
            }
        }
    }
}