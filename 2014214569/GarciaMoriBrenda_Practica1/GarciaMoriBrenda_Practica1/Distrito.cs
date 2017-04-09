using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaMoriBrenda_Practica1
{
    class Distrito
    {
        Provincia provincias = new Provincia();

        public string distrito { get; set; }
        public string provincia { get; set; }

        public Distrito(){}

        public Distrito(string dis)
        {
            distrito = dis;
            provincia = provincias.provincia;
        }

    }
}
