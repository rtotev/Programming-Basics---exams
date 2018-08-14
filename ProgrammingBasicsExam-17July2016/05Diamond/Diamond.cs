using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('.', n) + new string('*', 3 * n) + new string('.', n));
            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine(new string('.', n-(i+1)) + '*' + new string('.', 3*n + 2*i) + '*' + new string('.', n - (i + 1)));
            }
            Console.WriteLine(new string('*', 5*n));
            for (int i = 0; i < 2*n ; i++)
            {
                Console.WriteLine(new string('.', i+1) + '*' + new string('.', (n*5-4)-(i*2)) + '*' + new string ('.', i+1));
            }
            Console.WriteLine(new string('.', n*2+1) + new string('*', n-2) + new string('.', n * 2 + 1));
        }
    }
}
