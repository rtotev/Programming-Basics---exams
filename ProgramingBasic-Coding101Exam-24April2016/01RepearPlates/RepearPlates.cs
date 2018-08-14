using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01RepearPlates
{
    class RepearPlates
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int o = int.Parse(Console.ReadLine());
            int size = n * n;
            int bench = o * m;
            double plate = w * l;
            double needPlates = (size - bench) / plate;
            double result = needPlates * 0.2;
            Console.WriteLine(needPlates);
            Console.WriteLine(result);



        }
    }
}
