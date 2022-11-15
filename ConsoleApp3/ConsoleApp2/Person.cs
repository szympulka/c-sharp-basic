using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Person
    {
        public string name;
        public int age;
        private double weight;
        private double height;

        public Person(double weightComing, double heightComing)
        {
            weight = weightComing;
            height = heightComing;
        }
        public Person()
        {

        }

        public double GetBMI()
        {
            double bmi = weight / height;
            return bmi;
        }

        public void ShowAll()
        {
            Console.WriteLine($"{name} ma {age} lat i jego bmi to {GetBMI()}");
        }

    }
}
