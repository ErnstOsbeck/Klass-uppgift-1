using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    internal class Bilar
    {
        public string Märke;
        public string Modell;
        public string Färg;
        public string Motor;
        public string Kraft;

        public void Bil()
        {
            Console.Write(Märke);
            Console.WriteLine(" " + Modell);
            Console.WriteLine("Färg: " + Färg);
            Console.WriteLine("Motor: " + Motor);
            Console.WriteLine("Effekt: " + Kraft);
        }

    }
}
