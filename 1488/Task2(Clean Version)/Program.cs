using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Clean_Version_
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int N = int.Parse(Console.ReadLine());
            double total = 1;
            double b = 1;
            for (int i=3;i<=N; i+=2)
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
            Console.ReadKey();
        }
    }
}
