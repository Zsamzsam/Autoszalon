using System;
using System.Security.Cryptography.X509Certificates;

namespace Autoszalon
{
    internal class Szemelyauto : Jarmu
    {
        int UlesekSzama { get; set; }
        double Fogyasztas { get; set; }
        string Szin { get; set; }

        public Szemelyauto(string gyarto, string modell, int evjarat, int alapAr, int kilometerAllas ,int ulesekSzama, double fogyasztas, string szin) : base(gyarto, modell, evjarat, alapAr, kilometerAllas )
        {
            UlesekSzama = ulesekSzama;
            Fogyasztas = fogyasztas;
            Szin = szin;

        }

        public void KenyelmiExtraBeszerzese(string extra)
        {
            Console.WriteLine("Szeretne autójába kényelmi eszközöket beszerelni? Igen/Nem");
            string valasz = Console.ReadLine();
            if (valasz.ToLower() == "igen")
            {
                Console.WriteLine($"Az autóba légkondi lett szerelve. {AlapAr + 90000}");
                Console.WriteLine($"Az autóba szervó lett szerelve. {AlapAr + 80000}");
                Console.WriteLine($"Az autóba bőr ülések lettek berakva. {AlapAr + 70348}");
            }
            else
            {
                Console.WriteLine("Nem szeretne kényelmi eszközöket beszerelni.");
            }
        }
        public void SzinFrissitese(string szin)
        {
            Szin = szin;
            Console.WriteLine($"Az autó színe: {Szin}");
        }


    }
}
