using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if ((a>=b)&&(b>=c))
            {
                
                Console.WriteLine(a-c); // ac
            }
           else if ((b>=a)&&(a>=c))
            {
                
                Console.WriteLine(b-c); //bc
            }
            else if ((a>=c)&&(c>=b)) //ab
            {
                
                Console.WriteLine(a-b);
            }
            else if ((b>=c)&&(c>=a))
            {
                
                Console.WriteLine(b-a); //ba
            }
            else if ((c>=b)&&(b>=a))
            {
                
                Console.WriteLine(c-a); //ca
            }
            else if ((c>=a)&&(a>=b))
            {
                
                Console.WriteLine(c-b); //cb
            }
            
            Console.ReadKey();
            

        }
    }
}
