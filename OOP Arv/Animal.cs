using OOP_Arv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal abstract class Animal //base class
    {

        //five common attributes with default values
        public string Name { get; set; } = "No name";
        public int Age { get; set; } = 0;
        public bool Domesticated { get; set; } = false;
        public string Color { get; set; } = "no color";
        public int NumberOfLegs { get; set; } = 0;


        public Animal(string name, int age, bool domesticated, string color, int numberOfLegs)
        {
            Name = name;
            Age = age >= 0 ? age : 0;
            Domesticated = domesticated;
            Color = color;
            NumberOfLegs = numberOfLegs >= 0? numberOfLegs : 0;
        }

        //common methods, of which MakeSound() is virtual to allow being overridden by subclasses
        public virtual void MakeSound()
        {
            Console.WriteLine($"*{Name} gör ett generiskt djurläte*");
        }

        public void Eat()
        {
            Console.WriteLine($"*{Name} äter*");
        }

        public void Sleep()
        {
            Console.WriteLine($"*{Name} sover*");
        }

        public void PrintAttributesOfAnimal()
        {
            Console.WriteLine($"{Name}s egenskaper");
            Console.WriteLine($"Ålder: {Age}");
            Console.WriteLine($"Tam: {Domesticated}");
            Console.WriteLine($"Färg: {Color}");
            Console.WriteLine($"Antal ben: {NumberOfLegs}");
            Console.WriteLine();
        }
    }
}