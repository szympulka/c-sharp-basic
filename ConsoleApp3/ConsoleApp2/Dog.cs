using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Dog
    {
        public int Age { get; set; }
        public string Name { get; private set; } = "Azor";

        public void SetName(string name)
        {
            GetVoice();
            Name = name;
        }

        private void GetVoice()
        {
            Console.WriteLine("Hau");
        }
    }
}
