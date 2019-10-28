using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            bool b = false;
            for (int x=1; x<N; x++)
            {
                for (int y=1; y<N; y++)
                {
                    for (int z=1; z<N; z++)
                    {
                        if (Math.Pow(x,3)+Math.Pow(y,3)+Math.Pow(z,3)==N)
                        {
                            Console.WriteLine($"{x}   {y}   {z}");
                            b = true;
                        }
                        
                    }
                }
            }
            if (b==false)
            {
                Console.WriteLine("No such combinations!");
            }
            Console.ReadKey();
        }
    }
}
