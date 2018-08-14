using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            double studio = 0;
            double flat = 0;
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());
            if (month == "May" || month == "October")
            {
                if(nights > 0 || nights <= 7)
                {
                    studio = nights * 50;
                    flat = nights * 65;
                }
                if (nights > 7 && nights <=14 )
                {
                    studio = nights * (50-50 * 0.05);
                    flat = nights * 65;
                }
                if (nights > 14)
                {
                    studio = nights * (50-50 * 0.3);
                    flat = nights *(65 - 65 * 0.1);
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights >0 && nights <=14)
                {
                    studio = 75.2 * nights;
                    flat = 68.7 * nights;
                }
                else if (nights > 14)
                {
                    studio = nights * (75.2 - 75.2 * 0.2);
                    flat = nights *(68.7 - 68.7*0.1);
                }
            }
            else if (month == "Jule" || month == "August")
            {
                if (nights > 0 && nights <= 14)
                {
                    studio = 76 * nights;
                    flat = 77 * nights;
                }
                else if(nights >14)
                {
                    studio = 76 * nights;
                    flat = nights *(77 - 77  * 0.1);
                }
            }            
            Console.WriteLine("Apartment: {0:0.00} lv.", flat);
            Console.WriteLine("Studio: {0:0.00} lv.", studio);
        }
    }
}
