using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv__inheritance_
{
    public class Dog : Animals
    {
        public string running;

        public Dog(string _Animal, string _Color, float _Weight, string _Move)
        {
            this.Animal = _Animal;
            this.Color = _Color;
            this.Weight = _Weight;
            this.running = _Move;
        }

        public void IsRunning()
        {
            Console.WriteLine(this.Animal + " is " + running);
        }
    }
}
