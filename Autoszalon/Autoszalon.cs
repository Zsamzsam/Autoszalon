using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszalon
{
    internal class Autoszalon
    {
        List<Jarmu> jarmuvek = new List<Jarmu>();

        public void JarmuHozzaadasa(Jarmu jarmu)
        {
            jarmuvek.Add(jarmu);
        }

        public void JarmuEladasa(string gyarto, string modell)
        {

        }

        public void JarmuvekListazasa()
        {
            foreach (var jarmu in jarmuvek)
            {
                jarmu.JarmuInfo();
            }
        }
    }
}
