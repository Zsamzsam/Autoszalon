using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszalon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autoszalon autoszalon = new Autoszalon();
            Szemelyauto szemelyauto = new Szemelyauto(gyarto: "Toyota", modell: "Corolla", evjarat: 2021, alapAr: 8000000, kilometerAllas: 1500, ulesekSzama: 5, fogyasztas:6.5, szin: "Fehér" );

            Terepjaro terepjaro = new Terepjaro(gyarto: "Land Rover", modell: "Defender", evjarat: 2020, alapAr: 15000000, kilometerAllas: 2000, hajtas: "4WD", offroadKepessegek: true, vontatokepesseg: 3500);

            autoszalon.JarmuHozzaadasa(szemelyauto);

            autoszalon.JarmuHozzaadasa(terepjaro);
            Console.WriteLine(autoszalon.JarmuEladasa("Toyota", "Corolla"));
            Jarmu jarmu = autoszalon.JarmuKeresese("Land Rover", "Defender");
            jarmu.JarmuInfo();

            autoszalon.JarmuvekListazasa();

            Console.ReadKey();
        }
    }
}
