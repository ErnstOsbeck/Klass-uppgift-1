using System;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilar B1 = new Bilar();
            B1.Märke = "Ferrari";
            B1.Modell = "LaFerrari";
            B1.Färg = "Rosso Corsa";
            B1.Motor = "6.3L V12 + elektrisk motor/KERS";
            B1.Kraft = "950hp";

            B1.Bil();
        }
    }
}