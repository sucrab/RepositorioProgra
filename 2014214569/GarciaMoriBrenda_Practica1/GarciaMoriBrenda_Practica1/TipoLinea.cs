using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaMoriBrenda_Practica1
{
    class TipoLinea
    {
        public string tipolinea1 { get; set; }

        public TipoLinea()
        {


        }

        public TipoLinea(int num)
        {
            tipolin(num);

        }

        public void tipolin(int num)
        {
            if (num == 982096748 || num == 942463134 || num == 123456789)
            {

                tipolinea1 = "Post-Pago";
            }
            else
            {
                tipolinea1 = "Pre-Pago";
            }
        }
            
    }
}
