using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszalon
{
    internal class Jarmu
    {
        public string Gyarto { get; set; }
        public string Modell { get; set; }
        public int Evjarat { get; set; }
        public int AlapAr {  get; set; }
        int KilometerAllas { get; set; }

        public Jarmu(string gyarto, string modell, int evjarat, int alapAr,int kilometerAllas)
        { 
            Gyarto = gyarto;
            Modell = modell;
            Evjarat = evjarat;
            AlapAr = alapAr;
            KilometerAllas = kilometerAllas;

        }
        public void JarmuInfo()
        {
            Console.WriteLine($"Gyártó: {Gyarto} ");
            Console.WriteLine($"Modell: {Modell}");
            Console.WriteLine($"Évjárat: {Evjarat}");
        }

        public void ArKalkulacio()
        {
            int AktualisEv = DateTime.Now.Year;
            int Evek = AktualisEv - Evjarat;
            int Csokkenes = Evek - 5000;

            Console.WriteLine($"Az autó aktuális ára: {AlapAr - Csokkenes}");
        }

        public void KmAllasFrissites(int km)
        {
            KilometerAllas = km;
            Console.WriteLine($"Az autó kilométeróra állása: {KilometerAllas}");
        }
    }
}
