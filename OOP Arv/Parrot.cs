using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Parrot : Animal //a subclass to animal
    {
        public bool CanTalk { get; set; } = false; //unique attribute for parrots with default value

        public Parrot(string name, int age, bool domesticated, string color, int numberOfLegs, bool canTalk) : base(name, age, domesticated, color, numberOfLegs)
        {
            CanTalk = canTalk;
        }

        public override void MakeSound()
        {
            if (CanTalk)
            {
                Console.WriteLine($"*{Name} imiterar*");
            }
            else
            {
                Console.WriteLine($"*{Name} kvittrar*");
            }
        }

        public void Fly() //unique method for parrots
        {
            Console.WriteLine($"*{Name} flyger*");
        }
    }
}
