using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polif
{
    public class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; } = "Animal";

        public virtual string GetVoice()
        {
            return "Voice";
        }
    }

    public class Dog : Animal
    {
        public Dog()
        {
            base.Name = "dog"; // Z klasy bazowej
            Console.WriteLine(base.GetVoice());
            Console.WriteLine(this.GetVoice());
        }

        public int Legs { get; set; }

        public override string GetVoice()
        {
            return "Hau hau";
        }

    }

    public class Cat : Animal
    {

        public string GetHumor()
        {
            return "Funny";
        }

        public override string GetVoice()
        {
            return "Mial mial";
        }
    }
}
