using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv__inheritance_
{
    public class Fish : Animals
    {
        public string swim;
      
        public Fish(string _Animal, string _Color, float _Weight, string _Move)
        {
            this.Animal = _Animal;
            this.Color = _Color;
            this.Weight = _Weight;
            this.swim = _Move;        
        }

        public override void MakeSound()
        {
            Console.WriteLine(this.Animal + " goes ... because it doesn't make a sound ");
        }

        public void isSwimming()
        {
            Console.WriteLine(this.Animal + " is " + this.swim);
        }
    }
}
