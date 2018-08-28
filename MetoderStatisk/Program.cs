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

            //if (System.IO.File.Exists(@"c:\temp\test.txt")) {
            //    Console.WriteLine("Hurra - filen blev fundet.");
            //}
            //else
            //    Console.WriteLine("Filen eksisterer ikke.");


            string sti = "c:\\temp\\tal.txt";
            //if (!System.IO.File.Exists(sti))
            //    throw new ApplicationException("Filen c:\\temp\\tal.txt findes ikke!");

            string indhold = "";
            try
            {
                indhold = System.IO.File.ReadAllText(sti);
                int tal = Convert.ToInt32(indhold);
                tal++;
                System.IO.File.WriteAllText(sti, tal.ToString());
                Console.WriteLine($"Tal i fil er nu {tal}");
            }
            catch (System.FormatException)
            {
                throw new ApplicationException($"'{indhold}' kan ikke konverteres til et heltal");

            }
            catch (Exception)
            {
                throw;
            }







            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
