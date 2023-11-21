using Planetario.Frontend.Crear.Viajes_Espaciales;
using Planetario.Frontend.Editrar.Viajes_Espaciales;
using Planetario.Frontend.Eliminar.Viajes_Espaciales;
using Planetario.Frontend.Mostrar.Viajes_Espaciales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Principal.Viajes_Espaciales
{
    public class MenuAstronauta
    {
        public static void MostrarMenu()
        {
            int _opcionUsuario = 3;

            Console.Clear();

            while (_opcionUsuario != 0)
            {
                Console.WriteLine("\nMenu Astronauta");
                Console.WriteLine("Seleccione una opcion: ");
                Console.WriteLine("1. Crear astronauta");
                Console.WriteLine("2. Visualizar astronautas");
                Console.WriteLine("3. Editar astronauta");
                Console.WriteLine("4. Eliminar astronauta");
                Console.WriteLine("0. Salir del menu de astronautas");
                Console.WriteLine("Seleccione una opcion: ");

                _opcionUsuario = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (_opcionUsuario)
                {
                    case 1:
                        CrearAstronauta.Crear();
                        break;

                    case 2:
                        MostrarAstronautas.Mostrar();
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 0:
                        break;

                    default:
                        MostrarMenu();
                        break;
                }
            }
        }
    }
}
