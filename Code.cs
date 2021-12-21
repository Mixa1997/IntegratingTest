using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratingTest
{
    class Code
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Trigfunk.Trigfunk.Power(5, 2));
            Console.WriteLine(Math.Pow(5, 2));


            double a = Math.Log(1024, 2);
            double b = Math.Log(1024) / Math.Log(2);


            Console.WriteLine("{0} {1}", a, b);
            Console.WriteLine(Math.Log(100));
            Console.WriteLine(Trigfunk.Trigfunk.Power(5, 2));
            Console.WriteLine("\n\n");
            Console.WriteLine("Введите х: ");
            double x = double.Parse(Console.ReadLine());
            double result = 0;
            if (x <= 0)
            {
                result = (((Trigfunk.Trigfunk.Power(Trigfunk.Trigfunk.Power(((Trigfunk.Trigfunk.Sin(x) - Trigfunk.Trigfunk.Ctan(x) + Trigfunk.Trigfunk.Ctan(x))), 3), 2)) + ((Trigfunk.Trigfunk.sec(x) + Trigfunk.Trigfunk.Cos(x)))));
            }
            else
            {
                result = ((((Trigfunk.Trigfunk.Power(Trigfunk.Trigfunk.Ln(x), 2) - Trigfunk.Trigfunk.Log_2(x, 2)) / ((Trigfunk.Trigfunk.Log_3(x, 3) * Trigfunk.Trigfunk.Log_2(x, 2)) * Trigfunk.Trigfunk.Ln(x)) * Trigfunk.Trigfunk.Power(Trigfunk.Trigfunk.Log_10(x, 10), 2))));
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
