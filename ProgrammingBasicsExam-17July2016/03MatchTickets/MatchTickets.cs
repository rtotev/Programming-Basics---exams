using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03MatchTickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            if(people > 0  && people < 5)
            {
                budget -= budget*0.75; 
            }
            else if (people > 4 && people < 10)
            {
                budget -= budget * 0.60;
            }
            else if (people > 9 && people < 25)
            {
                budget -= budget * 0.50;
            }
            else if (people > 24 && people < 50)
            {
                budget -= budget * 0.40;
            }
            else if (people > 49)
            {
                budget -= budget * 0.25;
            }
            double ticketsPrice = 0;
            if (category == "VIP")
            {
                 ticketsPrice = 499.99 * people;
            }
            else
            {
                 ticketsPrice = 249.99 * people;
            }

            double result = budget - ticketsPrice;
            if (result >= 0)
            {
                Console.WriteLine("Yes! You have {0:0.00} leva left.", result);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:0.00} leva.", Math.Abs(result));
            }

        }
    }
}
