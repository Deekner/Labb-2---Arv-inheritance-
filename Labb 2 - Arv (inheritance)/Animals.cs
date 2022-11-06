using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv__inheritance_
{
    public class Animals
    {
        public string Animal;
        public string Color;
        public double Weight;
        public string Move;

        public Animals()
        {
            Animal = "Unknown animal";
            Color = "Unknown color";
            Weight = 0;
            Move = "Unknown move";
        }
        public Animals(string _Animal, string _Color, float _Weight, string _Move)
        {
            this.Animal = _Animal;
            this.Color = _Color;
            this.Weight = _Weight;
            this.Move = _Move;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine(Animal + " goes *Woof* *Woof* ");
        }

        public void Eat()
        {
            Console.WriteLine(Animal + " is Eating ");
        }

        public void Sleep()
        {
            Console.WriteLine(Animal + " is sleeping ");
        }

    }
}
