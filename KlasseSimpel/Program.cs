using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseSimpel
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.efternavn = "Andersen";
            p1.fornavn = "Finn";
            p1.fødselsår = 1965;
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.Alder());


            Person p2 = new Person("Berit", "Andersen", 1964);
            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.Alder());

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
