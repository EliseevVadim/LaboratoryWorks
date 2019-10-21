using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int a = N / 2;
            int z = N / 2 + 1;// плюсы
            int q = N - z;//минусы
            int b = 1;// первый знаменатель
            int l = 3;// второй знаменатель
            double u = 1; // единица
            double c = 0; // частное1
            double d = 0;
            double counter1 = 0;
            double counter2 = 0;
            if (N%2==0)
            {
                for (int i=0;i<=a;i++)
                {
                    counter1 += c; 
                    c = u / b;
                    b += 4;
                }
                for (int j=0;j<=a;j++)
                {
                    counter2 += d;
                    d = u / l;
                    l += 4;
                }
                double pi = 4 * (counter1 - counter2);
                Console.WriteLine(pi);
                
                
            }
            else
            {
                for (int i = 0; i <= z; i++)
                {
                    counter1 += c;
                    c = u / b;
                    b += 4;
                }
                for (int j = 0; j <= q; j++)
                {
                    counter2 += d;
                    d = u / l;
                    l += 4;
                }
                double pi = 4 * (counter1 - counter2);
                Console.WriteLine(pi);

            }
            Console.ReadKey();



        }
    }
}
