using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaMoriBrenda_Practica1
{
    class Direccion
    {
        Ubigeo ub = new Ubigeo();

        public string direcc { get; set; }
        public string ubig { get; set; }

     
        public Direccion()
        {

        }
        public Direccion(string direc)
        {
            direcc = direc;
            ubig = ub.ubigeo;

        }
    }
}
