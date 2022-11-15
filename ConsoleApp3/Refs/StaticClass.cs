using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refs
{
    public class StaticClass
    {
        public static void Test()
        {
            Test2();
            Console.WriteLine("test");
        }

        public static void Test2()
        {
            Console.WriteLine("test2");
        }
    }
}
