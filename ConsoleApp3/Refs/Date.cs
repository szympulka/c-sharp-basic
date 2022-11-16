using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Refs
{
    internal static class Date
    {
        public static void ShowDate()
        {
            var now = DateTime.Now.AddDays(22).AddHours(44).AddMinutes(123456);
            var dayOfWeek = now.DayOfWeek;
            var dayofweek = now.ToString("dddd");

            string favoriteTask = now.DayOfWeek switch
            {
                DayOfWeek.Sunday => "Niedziela",
                DayOfWeek.Monday => throw new NotImplementedException(),
                DayOfWeek.Tuesday => throw new NotImplementedException(),
                DayOfWeek.Wednesday => throw new NotImplementedException(),
                DayOfWeek.Thursday => throw new NotImplementedException(),
                DayOfWeek.Friday => throw new NotImplementedException(),
                DayOfWeek.Saturday => throw new NotImplementedException(),
            };

            Console.WriteLine(favoriteTask);
        }
    }
}
