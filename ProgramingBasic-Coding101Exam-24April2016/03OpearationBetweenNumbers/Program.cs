using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03OpearationBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());
            double result=0;
            if(n2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);
            }
            else
            {            
                switch (sign)
                {
                    case '+':
                        result = n1 + n2;
                        break;
                    case '-':
                        result = n1 - n2;
                        break;
                    case '/':
                        result = n1 / n2;
                        break;
                    case '*':
                        result = n1 * n2;
                        break;    
                    default:
                        break;
                }
                if (sign == '+' || sign == '-' || sign == '*')
                {
                    string isEven = "odd";
                    if (result % 2 == 0)
                                    {
                                        isEven = "even";
                                    }
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, sign, n2, result, isEven);                           
                }
                else if(sign == '/')
                {
                    Console.WriteLine("{0} {1} {2} = {3:0.00}", n1, sign, n2, result);
                }
                else
                {
                    double difference = n1 % n2;
                    Console.WriteLine("{0} {1} {2} = {3}", n1, sign, n2, difference);
                }
            }
        }
    }
}
