using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseSimpel
{
    class Person
    {
        public string fornavn;
        public string efternavn;
        public int fødselsår;

        public string FuldtNavn()
        {
            return fornavn + " " + efternavn;
        }

        public int Alder()
        {
            int curÅr = DateTime.Now.Year;
            return curÅr - fødselsår;
        }

        public Person()
        {
            fornavn = "";
            efternavn = "";
        }

        public Person(string fNavn, string eNavn, int fÅr)
        {
            fornavn = fNavn;
            efternavn = eNavn;
            fødselsår = fÅr;
        }
    }
}
