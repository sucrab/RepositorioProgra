using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaMoriBrenda_Practica1
{
    class CentrodeAtencion
    {
        Direccion dirreccio = new Direccion();

        public string centroAtencion { get; set; }
        public string direccion { get; set; }

        public CentrodeAtencion() { }
        public CentrodeAtencion(string centroAtencion)
        {
            this.centroAtencion = centroAtencion;
            direccion = dirreccio.direcc;
        }
    }
}
