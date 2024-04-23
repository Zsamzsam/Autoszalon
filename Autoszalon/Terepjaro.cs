using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszalon
{
    internal class Terepjaro : Jarmu
    {
        string Hajtas { get; set; }
        bool OffroadKepessegek  { get; set; }

        bool offroadKepessegek = false;

        int Vontatokepesseg { get; set; }


        public Terepjaro(string gyarto, string modell, int evjarat, int alapAr, int kilometerAllas ,string hajtas, bool offroadKepessegek, int vontatokepesseg) : base(gyarto, modell, evjarat, alapAr, kilometerAllas)
        {
            Hajtas = hajtas;
            OffroadKepessegek = offroadKepessegek;
            Vontatokepesseg = vontatokepesseg;
        }

        public void OffroadCsekk()
        {
            Console.WriteLine("Szeretne autójába offroad képességeket beszerelni? Igen/Nem");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                Console.WriteLine($"Az autó képes offroadolni.{AlapAr + 400000} ");
                offroadKepessegek = true;
            }
            else
            {
                Console.WriteLine("Nem szereltett be semmit.");
                
            }

        }

        public void VontatoepessegBeallitasa(int kepesseg)
        {
            Vontatokepesseg = kepesseg;
            Console.WriteLine($"A terepjáró vontatóképessége: {Vontatokepesseg}");
        }
    }
}
