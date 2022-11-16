using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polif
{
    public class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; } = "Animal";

        public string GetVoice()
        {
            return "Voice";
        }
    }

    public class Dog : Animal
    {
        private string age;
        public Dog()
        {
            base.Name = "dog"; // Z klasy bazowej
            this.age = "adsfadsf";
        }

        public int Legs { get; set; }

    }

    public class Cat : Animal
    {
        public string GetHumor()
        {
            return "Funny";
        }
    }
}
