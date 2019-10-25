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
            int fact = 1;
            int counter = 0;
            double step = 1;
            double cos_of_x = 1;
            while (q<=step)
            {
                if (counter%2==0)
                {
                    for (int i=1; i<=N;i++)
                    {
                        fact *= i;
                    }
                    step = Math.Pow(x, N) / fact;
                    cos_of_x -= step;
                }
                else
                {
                    for (int i = 1; i <= N; i++)
                    {
                        fact *= i;
                    }
                    step = Math.Pow(x, N) / fact;
                    cos_of_x += step;
                }
                counter++;
                N += 2;

            }
            Console.WriteLine(cos_of_x);
            Console.ReadKey();
            
        }
    }
}
