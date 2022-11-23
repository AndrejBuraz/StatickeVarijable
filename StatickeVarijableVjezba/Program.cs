using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatickeVarijableVjezba
{
    class PrvaKlasa
    {
        private static int counter;

        public PrvaKlasa()
        {
            counter++;
        }
        public int Counter()
        {
            return counter;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PrvaKlasa x = new PrvaKlasa();
            PrvaKlasa y = new PrvaKlasa();
            PrvaKlasa z = new PrvaKlasa();
            Console.WriteLine("Vrijednost staticke varijable counter: " + x.Counter());
            Console.ReadKey();
        }
    }
}
