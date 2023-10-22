namespace OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat morrGan = new Cat("Morr-gan", 3, true, "orange", 4, true);
            morrGan.PrintAttributesOfAnimal();
            morrGan.MakeSound();
            morrGan.ActSassy();
            morrGan.Eat();
            morrGan.Sleep();
            Console.WriteLine("\n");

            Dog chewie = new Dog("Chewie", 5, true, "svart", 4, "boll");
            chewie.PrintAttributesOfAnimal();
            chewie.MakeSound();
            chewie.PlayWithToy();
            chewie.Eat();
            chewie.Sleep();
            Console.WriteLine("\n");

            Parrot squawkabilly = new Parrot("Squawkabilly", 15, true, "grön", 2, true);
            squawkabilly.PrintAttributesOfAnimal();
            squawkabilly.MakeSound();
            squawkabilly.Fly();
            squawkabilly.Eat();
            squawkabilly.Sleep();
            Console.WriteLine("\n");

            Macaw captainFlint = new Macaw("Captain Flint", 60, true, "färggrann", 2, true, true);
            captainFlint.PrintAttributesOfAnimal();
            captainFlint.MakeSound();
            captainFlint.DoATrick();
            captainFlint.Fly();
            captainFlint.Eat();
            captainFlint.Sleep();
            Console.WriteLine("\n");

            Budgie disco = new Budgie("Disco", 4, true, "green", 2, true, "Disco! Meet the Disco! He's a yabba dabba doo bird, a dabba doo bird!");
            disco.PrintAttributesOfAnimal();
            disco.MakeSound();
            disco.JumpAround();
            disco.Fly();
            disco.Eat();
            disco.Sleep();
            Console.WriteLine("\n");


            /*
             ************ EXTRA UTMANING ***********
             * Gör så att även människa finns som ett djur.
             * Utöka strukturen så att det görs skillnad på däggdjur och reptiler.
             * Utöka programmet så att det även finns en uppdelning mellan vilda och tama djur.
             * Utöka programmet så att strukturen även omfattar växter.
             */
        }
    }
}