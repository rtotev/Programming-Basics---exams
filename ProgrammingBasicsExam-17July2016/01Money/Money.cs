using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Money
{
    class Money
    {
        static void Main(string[] args)
        {
            int bitcoint = int.Parse(Console.ReadLine());
            double yoan = double.Parse(Console.ReadLine());
            double comision = double.Parse(Console.ReadLine());
            int bitcointPrise = 1168;
            double dolarPrise = 1.76;
            double yoanPrise = 0.15 * dolarPrise;           
            double euroPrise = 1.95;
            double leva = (bitcoint * bitcointPrise) + yoan*yoanPrise;
            double euro = leva / euroPrise;
            double result = euro;
            result -= euro * (comision / 100);
            Console.WriteLine(result);
        }
    }
}
