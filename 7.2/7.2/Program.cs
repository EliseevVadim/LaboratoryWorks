using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=10; i<100; i++)
            {
                int a = i / 10;
                int b = i % 10;
                int c = (a + b) % 5;
                if (c==0)
                {
                    Console.WriteLine(i);
                }
                
            }
            Console.ReadKey();
        }
    }
}
