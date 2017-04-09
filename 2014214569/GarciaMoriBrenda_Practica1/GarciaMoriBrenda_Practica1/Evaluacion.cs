using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaMoriBrenda_Practica1
{
    class Evaluacion
    {
        CentrodeAtencion centrEv = new CentrodeAtencion();
        Lineatelefonica line = new Lineatelefonica();
        EquipoCelular equipoce = new EquipoCelular();
        TipoPlan tipoplaEva = new TipoPlan();
        Plan planp = new Plan();
        estadoEvaluacion estadoEval = new estadoEvaluacion();
        trabajador trabajadores = new trabajador();
        tipoEvaluacion tipeEv = new tipoEvaluacion();
       
       

        public string evaluac { get; set; }
        public string lineaE { get; set; }
        public string equiposev { get; set; }
        public string planev { get; set; }
        public string trabajadorev { get; set; }
        public string estadoev { get; set; }
        public string tipoEvev { get; set; }
        public string clienev { get; set; }
        public string ventev { get; set; }
        public string centroev { get; set; }

        venta ven = new venta();
       
        public string verificaciontip(int num)
        {
            TipoLinea tip = new TipoLinea(num);
            return tip.tipolinea1;

        }

        public string verificacioncli(int num)
        {
            cliente cli = new cliente(num);

            return cli.clientes;
        }

        public Evaluacion(string evaluacion1)
        {
            planev = planp.plan;
            evaluac = evaluacion1;
            planev = planp.plan;
            tipoEvev = tipeEv.tipoEva;
            equiposev = equipoce.equipocelular;
            ventev = ven.ventas;
            centroev = centrEv.centroAtencion;
            trabajadorev = trabajadores.trabaja;
            estadoev = estadoEval.estado;
            lineaE = line.lineatelefonica;
        }

        public Evaluacion(){}

        public string evaluardos(string plan)
        {
            string mensaje = "";

            if (plan.Equals("RPM Ilimatdo + 2GB"))
            {
                mensaje = "Portabilidad Aprobada";
            }
            if (plan.Equals("500 Minutos + 1GB + 500 MSN"))
            {
                mensaje = "ENueva Linea Aprobada";
            }
            if (plan.Equals("RPM Ilimitado + 500 MB"))
            {
                mensaje = "Renovacion aprobada";

            }
         
            return mensaje;
        }

        public string tipoplansacar(int numero)
        {
            TipoPlan obj = new TipoPlan(numero);
            return obj.tipoPlan;
        }
    }
}
