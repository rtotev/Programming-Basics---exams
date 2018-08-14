using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06StopNumber
{
    class StopNumber
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            while (M>=N)
            {
                if (M%3==0 && M%2==0)
                {
                    if (M == stop)
                    {
                        break;
                    }
                    Console.Write(M + " ");
                }
                M--;
            }
        }
    }
}
