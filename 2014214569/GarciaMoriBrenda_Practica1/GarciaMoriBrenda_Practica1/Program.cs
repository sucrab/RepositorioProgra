using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaMoriBrenda_Practica1
{
    class Program
    {
        static void Main(string[] args)
        {

            var evalua = new Evaluacion();

            string texto1 = "";
            string texto2 = "";

            Console.WriteLine("Numero del Usuario: ");
            int numero = int.Parse(Console.ReadLine());

            string usuario = evalua.verificacioncli(numero);

            if (usuario == "No se encuentra registrado")
            {
                Console.WriteLine("Usuario no encontrado en la Base de Datos");

            }
            else
            {
                string tipo = evalua.verificaciontip(numero);
                Console.WriteLine("Cliente: \n" + usuario + " Tipo de Linea:" + tipo);
                Console.WriteLine("Desea Evaluar? - Evaluar / No Evaluar");
                texto1 = Console.ReadLine();

                if (texto1.Equals("Evaluar"))
                {
                    texto1 = Console.ReadLine();


                    Console.WriteLine("Resumen: \n Cliente: " + usuario + "\n Telefono: " + numero + "\n Tipo: " + tipo);

                    if (tipo.Equals("Post-Pago"))
                    {
                        Console.WriteLine("¿Evaluar?: Si/No");
                        texto1 = Console.ReadLine();
                        if (texto1.Equals("Si"))
                        {
                            string tipoplan = evalua.tipoplansacar(numero);
                            texto2 = evalua.evaluardos(tipoplan);
                            Console.WriteLine(texto2);
                        }
                        else
                        {
                            Console.WriteLine("Evaluacion Declinada");
                        }

                    }
                    else
                    {
                        texto2 = "El usuario no es apto para las promociones";
                    }
                    Console.WriteLine(texto2);


                }

            }

        }
    }
}
