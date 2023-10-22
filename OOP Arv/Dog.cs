using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Dog : Animal //a subclass to animal
    {

        public string FavoriteToy { get; set; } = "ingen"; //unique attribute for dogs with default value

        public Dog(string name, int age, bool domesticated, string color, int numberOfLegs, string favoriteToy) : base(name, age, domesticated, color, numberOfLegs)
        {
            FavoriteToy = favoriteToy;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"*{Name} säger: Voff voff!*");
        }

        public void PlayWithToy() //unique method for dogs
        {
            Console.WriteLine($"*{Name} leker med {FavoriteToy}*");
        }
    }
}
