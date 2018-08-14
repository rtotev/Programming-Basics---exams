using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04BackToThePast
{
    class BackToThePast
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine()) - 1800;
           int ivanchoYear = 18;
            for (int i = 0; i <= years; i++)
            {
                if (i%2==0)
                {
                    money -= 12000;
                }
                else
                {
                    money -= (12000 + (ivanchoYear * 50));

                }
                ivanchoYear++;
            }
            if (money < 0)
            {
                Console.WriteLine("He will need {0:0.00} dollars to survive.", Math.Abs(money));
            }
            else
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:0.00} dollars left.", money);
            }
        }
    }
}
