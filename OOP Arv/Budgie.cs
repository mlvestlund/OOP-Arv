using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Budgie : Parrot //a subclass to parrot, which is a subclass to animal
    {
        public string FavoritePhrase { get; set; } = "kvitter"; //unique attribute for budgies with default value

        public Budgie(string name, int age, bool domesticated, string color, int numberOfLegs, bool canTalk, string favoritePhrase) : base(name, age, domesticated, color, numberOfLegs, canTalk)
        {
            FavoritePhrase = favoritePhrase;
        }

        public override void MakeSound()
        {
            if (CanTalk)
            {
                Console.WriteLine($"*{Name} säger: {FavoritePhrase}*");
            }
            else 
            { 
                Console.WriteLine($"*{Name} säger: kvitter kvitter*"); 
            }
        }

        public void JumpAround() //unique method for budgies
        {
            Console.WriteLine($"*{Name} hoppar runt*");
        }
    }
}
