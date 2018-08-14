using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int a, b, c, d;
            for (int i = 1111; i <= 9999; i++)
            {
                a = i / 1000;
                b = i / 100 % 10;
                c = i / 10 % 10;
                d = i % 10;
                if (a != 0 && b != 0 && c != 0 && d != 0)
                {
                    if (number % a == 0 && number % b == 0 && number % c == 0 && number % d == 0)
                    {
                        Console.Write("{0}{1}{2}{3} ", a, b, c, d);
                    }
                }
            }
        }
    }
}
