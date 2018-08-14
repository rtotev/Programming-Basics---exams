using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepingCatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int restDay = int.Parse(Console.ReadLine());
            int workingDay = 365 - restDay;
            int playingHours = restDay * 127 + workingDay*63;
            int result = playingHours - 30000;
            int hours; 
            int minutes; 
            if (result >= 0)
            {
                hours= result / 60;
                minutes = result - (hours * 60);
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
            else
            {
                hours = Math.Abs(result / 60);
                minutes = Math.Abs(result) - (hours * 60);
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
        }
    }
}
