using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SmartLili
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            decimal priceWash = decimal.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());
            int oddYear = 0;
            int evenYear = 0;
            int counter = 1;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    evenYear += 10*counter-1;
                    counter++;
                }
                else
                {
                    oddYear++;
                }
            }
            int savedMoney = oddYear*priceToy + evenYear;
            decimal result =Math.Round(savedMoney - priceWash, 2);
            if (result >= 0)
            {
                Console.WriteLine("Yes! {0}", result);
            }
            else
            {
                Console.WriteLine("No! {0}", Math.Abs(result));
            }
        }
    }
}
