using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderStatisk
{
    class Program
    {
        static void Main(string[] args)
        {

            if (System.IO.File.Exists(@"c:\temp\test.txt")) {
                Console.WriteLine("Hurra - filen blev fundet.");
            }
            else
                Console.WriteLine("Filen eksisterer ikke.");


            






            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
