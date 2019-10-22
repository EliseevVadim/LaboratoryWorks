using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            int f1 = 1;
            int f2 = 2;
            int counter = 0;
            while (true)
            {
                int pluser = f1;
                f1 = f2;
                f2 = f1 + pluser;
                
                if ((f1+f2)/1000>=1&&(f1+f2)/1000<=9)
                {
                    counter++;                
                }
                if (f1 + f2 > 9999)
                    break;
              

            }
            Console.WriteLine(counter);

            Console.ReadKey();
        }
    }
}
