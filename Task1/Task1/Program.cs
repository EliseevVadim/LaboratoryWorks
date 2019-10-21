using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double c = int.Parse(Console.ReadLine());
            double discriminant = b * b - 4 * a * c;
            if (a==0)
            {
                double x = -c / b;
                Console.WriteLine(x);
            }
            else if (b==0&&c<=0)
            {
                double x1 = Math.Sqrt(-c / a);
                double x2 = -Math.Sqrt(-c / a);
                Console.WriteLine($"{x1}   {x2}");
            }
            else if (b==0&&c>0)
            {
                Console.WriteLine("None!");
            }
            else if (c==0)
            {
                double x = -b / a;
                Console.WriteLine($"0   {x}");
            }
            if (discriminant==0)
            {
                double x = -b / (2 * a);
                Console.WriteLine(x);
            }
            else if (discriminant>0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
                double x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
                Console.WriteLine($"{x1}    {x2}");
            }
            else if (discriminant<0)
            {
                double absolute = Math.Abs(discriminant);
                double sabsolute = Math.Sqrt(absolute);
                double l = -b / (2 * a);
                double k = sabsolute / (2 * a);
                Console.WriteLine(l + "+" + k + "i");
                Console.WriteLine(l + "-" + k + "i");
            }
            Console.ReadKey();

        }
    }
}
