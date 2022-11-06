using System;

namespace Labb_2___Arv__inheritance_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------");

            Dog GoldenRetriever = new Dog("Dog", "Golden", 25, "Running");
            GoldenRetriever.MakeSound();
            GoldenRetriever.IsRunning();

            Console.WriteLine("------------------------------------------------");

            Fish Salmon = new Fish("Fish", "Cyan", 1.2f, "Swimming");
            Salmon.MakeSound();
            Salmon.isSwimming();

            Console.WriteLine("------------------------------------------------");

            Bird Hawk = new Bird("Hawk", "golden-brown", 1.1f, true);
            Hawk.MakeSound();
            Hawk.isFlying();

            Console.WriteLine("------------------------------------------------");

            Owl Owl = new Owl("Owl", "brown", 1.6f, true);
            Owl.MakeSound();
            Owl.isFlying();
            Owl.Sleep();

            Console.WriteLine("------------------------------------------------");

            Penguin Penguin = new Penguin("Penguin", "black and white", 35, false);
            Penguin.MakeSound();
            Penguin.isFlying();
            Penguin.Eat();

            Console.WriteLine("------------------------------------------------");
        }
    }
}
