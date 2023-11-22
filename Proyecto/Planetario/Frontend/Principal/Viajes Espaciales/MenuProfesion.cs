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
    public class MenuProfesion
    {
        public static void MostrarMenu()
        {
            int _opcionUsuario = 9;

            Console.Clear();

            while (_opcionUsuario != 0)
            {
                Console.WriteLine("\nMenu Profesion");
                Console.WriteLine("Seleccione una opcion: ");
                Console.WriteLine("1. Crear profesion");
                Console.WriteLine("2. Visualizar profesiones");
                Console.WriteLine("3. Editar profesion");
                Console.WriteLine("4. Eliminar profesion");
                Console.WriteLine("0. Salir del menu de profesiones");

                _opcionUsuario = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (_opcionUsuario)
                {
                    case 1:
                        CrearProfesion.Crear();
                        break;

                    case 2:
                        MostrarProfesion.Mostrar();
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 0:
                        MenuPrincipal.MostrarMenu();
                        break;

                    default:
                        MostrarMenu();
                        break;
                }
            }
        }
    }
}
