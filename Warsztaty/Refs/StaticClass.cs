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

    public static class qrwerqwerqwerqweewqrqwerrqwerw // Extension Metoda zawsze musi być statyczna
    {
        public static DateTime PolandTime(this DateTime date) // Słówko kluczowe this
        {
            return date.AddHours(2);
        }
        public static DateTime PolandTime(this DateTime date, int timeZone) // Słówko kluczowe this
        {
            return date.AddHours(timeZone);
        }
    }

}
