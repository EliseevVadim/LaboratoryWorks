using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите q");
            double q = double.Parse(Console.ReadLine());
            int N = 2;
            double fact = 1;
            int counter = 0;
            double step = 1;
            double cos_of_x = 1;
            while (q<=step)
            {
                if (counter%2==0)
                {
                    fact = factorial_WhileLoop(N);
                    step = Math.Pow(x, N) / fact;
                    cos_of_x -= step;
                }
                else
                {
                    fact= factorial_WhileLoop(N);
                    step = Math.Pow(x, N) / fact;
                    cos_of_x += step;
                }
                counter++;
                N += 2;

            }
            Console.WriteLine(cos_of_x);
            Console.ReadKey();

        }
        

public static double factorial_WhileLoop(double number)
        {
            double result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
    }
}
