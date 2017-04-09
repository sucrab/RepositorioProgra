using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaMoriBrenda_Practica1
{
    class contrato
    {
        public string contratoPlan { get; set; }

        public contrato() { }
        public contrato(string contra)
        {
            contratoPlan = contra;
        }
       
    }
}
