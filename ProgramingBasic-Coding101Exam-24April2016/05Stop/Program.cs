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
            int n = int.Parse(Console.ReadLine());
            string top = new string('.', n + 1) + new string('_', n * 2 + 1) + new string('.', n + 1);
            Console.WriteLine(top);
            for (int i = 0; i < n; i++)
            {
                string topLoop = new string('.', n - i) + "//" + new string('_', (n * 2 - 1) + 2 * i) + "\\\\" + new string('.', n - i);
                Console.WriteLine(topLoop);
            }
            string middle = "//" + new string('_', n * 2 - 3) + "STOP!" + new string('_', n * 2 - 3) + "\\\\";
            Console.WriteLine(middle);
            for (int i = 0; i < n; i++)
            {
                string bottomLoop = new string('.', i) + "\\\\" + new string('_', (n * 4 - 1) - i * 2) + "//" + new string('.', i);
                Console.WriteLine(bottomLoop);
            }
        }
    }
}
