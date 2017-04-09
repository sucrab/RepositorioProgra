using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaMoriBrenda_Practica1
{
    class venta
    {
        cliente cli = new cliente();
        contrato con = new contrato();
        tipoPago tipp = new tipoPago();
        CentrodeAtencion caten = new CentrodeAtencion();
        Lineatelefonica lin = new Lineatelefonica();


        public string ventas { get; set; }
        public string cliente { get; set; }
        public string contrato { get; set; }
        public string tipopago { get; set; }
        public string centraten { get; set; }
        public string linea { get; set; }



        public venta(string vent)
        {
            ventas = vent;
            cliente = cli.clientes;
            contrato = con.contratoPlan;
            tipopago = tipp.tipopago;
            centraten = caten.centroAtencion;
            linea = lin.lineatelefonica;
        }

        public venta()
        {

        }


    }
}
