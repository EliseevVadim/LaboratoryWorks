using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            byte N = byte.Parse(Console.ReadLine());
            int b = N % 10;
            if (N>100)
            {
                Console.WriteLine("Fail");
            }
        else   if (N>=10&&N<=20)
            {
                Console.WriteLine($"{N} лет");
            }
            else
            {
                switch (b)
                {
                    case 1: Console.WriteLine($"{N} год"); break;
                    case 2: Console.WriteLine($"{N} года"); break;
                    case 3: Console.WriteLine($"{N} года"); break;
                    case 4: Console.WriteLine($"{N} года"); break;
                    case 5: Console.WriteLine($"{N} лет"); break;
                    case 6: Console.WriteLine($"{N} лет"); break;
                    case 7: Console.WriteLine($"{N} лет"); break;
                    case 8: Console.WriteLine($"{N} лет"); break;
                    case 9: Console.WriteLine($"{N} лет"); break;
                    case 0: Console.WriteLine($"{N} лет"); break;

                }
            }
            
            Console.ReadKey();
        }
    }
}
