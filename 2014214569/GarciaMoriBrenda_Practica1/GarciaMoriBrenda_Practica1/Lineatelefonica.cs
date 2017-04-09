using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaMoriBrenda_Practica1
{
    class Lineatelefonica
    {
        TipoLinea linea = new TipoLinea();

        Administracionlinea admin = new Administracionlinea();

        public string lineatelefonica { get; set; }
        public string tipolinea { get; set; }
        public string administrador { get; set; }

        public Lineatelefonica(string lineatele)
        {
            lineatelefonica = lineatele;
            tipolinea = linea.tipolinea1;
            administrador = admin.administrador;
        }

        public Lineatelefonica()
        {
            
        }
    }
}
