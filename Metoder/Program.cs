using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"LægSammen : {LægSammen(3,5)}");

            Console.WriteLine($"BeregnAreal: {BeregnAreal(5)}");





            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }

        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal(int radius)
        {
            return radius * radius * System.Math.PI;
        }





}

    
}
