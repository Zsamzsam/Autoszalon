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

        public bool JarmuEladasa(string gyarto, string modell)
        {
            foreach (var jarmu in jarmuvek)
            {
                if (jarmu.Gyarto == gyarto && jarmu.Modell == modell)
                {
                    jarmuvek.Remove(jarmu);
                    return true;
                }
            }
            return false;
        }

        public Jarmu JarmuKeresese(string gyarto, string modell)
        {
            foreach (var jarmu in jarmuvek)
            {
                if (jarmu.Gyarto == gyarto && jarmu.Modell == modell)
                {
                    return jarmu;
                }
            }
            return null;
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
