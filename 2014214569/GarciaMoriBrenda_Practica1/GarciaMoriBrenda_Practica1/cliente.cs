using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaMoriBrenda_Practica1
{
    class cliente
    {
        public string clientes { get; set; }

        string[] personas = { "Brenda Garcia", "Victor Diaz", "Karla Garcia", "Miguel Garcia", "Grand Fantasia" };


        public cliente()
        {

        }
        public cliente(int numero)
        {
            clientes = generarCliente(numero);
        }

        public string generarCliente(int num)
        {
            if (num == 942463134)
            {
                return personas[0];
            }
            if (num == 982096748)
            {
                return personas[1];
            }
            if (num == 123456789)
            {
                return personas[2];
            }
            if (num == 123456788)
            {
                return personas[3];
            }
            if (num == 123456787)
            {
                return personas[4];
            }
            return "No se encuentra registrado";

        }

    }
}
