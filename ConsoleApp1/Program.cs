using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FilTyper ft = new FilTyper();
            ft = FilTyper.csv;

            Console.WriteLine(value: $"Aktuel filtype er: {ft.ToString()}" );

            Person p = new Person();
            p.Id = 1;
            p.Navn = "Mikkel";

             Console.WriteLine($"Navnet på personen er: {p.Navn}");



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
