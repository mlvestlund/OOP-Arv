using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Macaw : Parrot //a subclass to parrot, which is a subclass to animal
    {
        public bool IsPirate { get; set; } = false; //unique attribute for macaws with default value
        public Macaw(string name, int age, bool domesticated, string color, int numberOfLegs, bool canTalk, bool isPirate) : base(name, age, domesticated, color, numberOfLegs, canTalk)
        {
            IsPirate = isPirate;
        }

        public override void MakeSound()
        {
            if (CanTalk && IsPirate)
            {
                Console.WriteLine($"*{Name} säger: Pieces of eight!*");
            }
            else if (CanTalk && !IsPirate)
            {
                Console.WriteLine($"*{Name} imiterar*");
            }
            else 
            { 
                Console.WriteLine($"*{Name} kvittrar*"); 
            }
        }

        public void DoATrick() //unique method for macaws
        {
            Console.WriteLine($"*{Name} gör ett trick*");
        }
    }
}
