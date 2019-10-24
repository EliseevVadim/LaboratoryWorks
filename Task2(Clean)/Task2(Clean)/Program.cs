using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Clean_
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            double total = 1;
            int N = int.Parse(Console.ReadLine());
            double b = 1;
            if (N==2)
            {
                Console.WriteLine((1 - b / 3)*4);
            }
            else
            {
                for (int i=3; i<=N; i++)
                {
                    if (counter%2==0)
                    {
                        total -= b / i;
                    }
                    else
                    {
                        total += b / i;
                    }
                    counter++;
                }
                Console.WriteLine(total * 4);
            }
            Console.ReadKey();
        }
    }
}
