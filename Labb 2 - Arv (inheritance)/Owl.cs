using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv__inheritance_
{
    public class Owl : Bird
    {
        public Owl(string _Animal, string _Color, float _Weight, bool _fly)
        {
            this.Animal = _Animal;
            this.Color = _Color;
            this.Weight = _Weight;
            this.fly = _fly;
        }
        public override void MakeSound()
        {
            Console.WriteLine(this.Animal + " goes *HOOT* *HOOT*");
        }
        public void Isflying()
        {            
        }
        public void Sleep()
        {
            Console.WriteLine(this.Animal + " is sleeping ");
        }
    }
}
