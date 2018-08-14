using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Axe
{
    class Axe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('-', n*3) + '*'+ new string('-', i) + '*' + new string('-', n*2-2-i));
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine(new string('*', 3*n + 1) + new string('-', (2 * n - 2) / 2) + '*' +
                    new string ('-', (2*n-2)/2));
            }
            for (int i = 0; i < n/2; i++)
            {
                string middle = new string('-', (2 * n - 2) / 2 + 2*i);
                if (i == n / 2 -1)
                {
                    middle = new string('*', (2 * n - 2) / 2 + 2*i);
                } 
                Console.WriteLine(new string('-', 3*n - i) + '*' + middle + '*' + new string('-', (2 * n - 2) / 2 - i));
            }
        }
    }
}
