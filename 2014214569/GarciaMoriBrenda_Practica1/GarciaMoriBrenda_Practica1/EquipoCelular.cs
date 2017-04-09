using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaMoriBrenda_Practica1
{
    class EquipoCelular
    {
        AdministracionEquipo administracio = new AdministracionEquipo();

        public string equipocelular { get; set; }
        public string administrador { get; set; }


        public EquipoCelular() { }

        public EquipoCelular(string equipos)
        {
            administrador = administracio.administradorequipo;
            equipocelular = equipos;
        }

     

    }
}
