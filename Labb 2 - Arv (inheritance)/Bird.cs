using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv__inheritance_
{
    public class Bird : Animals
    {
        public bool fly;

        public Bird()
        {
            Animal = "Unknown animal";
            Color = "Unknown color";
            Weight = 0;
            Move = "Unknown move";
        }

        public Bird(string _Animal, string _Color, float _Weight, bool _fly)
        {
            this.Animal = _Animal;
            this.Color = _Color;
            this.Weight = _Weight;
            this.fly = _fly;
        }

        public override void MakeSound()
        {
            Console.WriteLine(this.Animal + " screams *kee-eeeee-arr*");
        }

        public void isFlying()
        {
            Console.WriteLine("Bird can fly: " + fly);
        }
        
    }
}
