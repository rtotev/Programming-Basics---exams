using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double grapePerMeter = double.Parse(Console.ReadLine());
            double needLiters = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double produceArea = area * grapePerMeter/2.5*0.4;
                        
            if (produceArea >= needLiters)
            {
                double totalWine = Math.Ceiling(produceArea - needLiters);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(produceArea));
                Console.WriteLine("{0} liters left -> {1} liters per person.",
                   Math.Ceiling(totalWine), Math.Ceiling(totalWine/workers));
            }
            else
            {
                double moreWine = needLiters - produceArea;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(moreWine));
            }
            
        }
    }
}
