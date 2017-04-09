using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaMoriBrenda_Practica1
{
    class TipoPlan
    {
        public string tipoPlan { get; set; }

        public string[] planes = { "RPM Ilimatdo + 2GB", "500 Minutos + 1GB + 500 MSN", "RPM Ilimitado + 500 MB" };


        public TipoPlan()
        {

        }

        public TipoPlan(int num)
        {
            tipo(num);
        }

        public void tipo(int num)
        {

            if (num == 982096748)
            {
                tipoPlan = "Conexion 69";
            }
            if (num == 942463134)
            {
                tipoPlan = "Conexion 29";
            }
            if (num == 123456789)
            {
                tipoPlan = "Conexion 99";
            }
        }
    }
}
