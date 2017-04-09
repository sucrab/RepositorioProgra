using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaMoriBrenda_Practica1
{
    class trabajador
    {
        tipoTrabajador tip = new tipoTrabajador();

        public string trabaja { get; set; }

        public string tipTraba { get; set; }

        public trabajador() { }

        public trabajador(string trab)
        {
            trabaja = trab;

            tipTraba = tip.tipodeTrabajador;
        }
    }
}
