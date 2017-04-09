using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaMoriBrenda_Practica1
{
    class Provincia
    {
        Departamento dpt = new Departamento();

        public string provincia { get; set; }
        public string departamento { get; set; }

        public Provincia()
        {

        }

        public Provincia(string prov)
        {
            provincia = prov;
            departamento = dpt.departamento;

        }
    }
}
