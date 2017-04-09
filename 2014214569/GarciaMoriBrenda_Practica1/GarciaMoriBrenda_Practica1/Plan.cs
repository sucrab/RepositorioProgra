using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaMoriBrenda_Practica1
{
    class Plan
    {

        TipoPlan tip = new TipoPlan();


        public string plan { get; set; }
        public string tipoPla { get; set; }

        public Plan() {}

        public Plan(string plan1)
        {

            plan = plan1;
            tipoPla = tip.tipoPlan;
        }
    }
}
