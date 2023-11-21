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
    public class MenuMision
    {
        public static void MostrarMenu()
        {
            int _opcionUsuario = 9;

            Console.Clear();

            while (_opcionUsuario != 0)
            {
                Console.WriteLine("\nMenu Mision");
                Console.WriteLine("Seleccione una opcion: ");
                Console.WriteLine("1. Crear mision");
                Console.WriteLine("2. Visualizar misiones");
                Console.WriteLine("3. Editar mision");
                Console.WriteLine("4. Eliminar mision");
                Console.WriteLine("0. Salir del menu de misiones");
                Console.WriteLine("Seleccione una opcion: ");

                _opcionUsuario = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (_opcionUsuario)
                {
                    case 1:
                        CrearMision.Crear();
                        break;

                    case 2:
                        MostrarMisiones.Mostrar();
                        break;

                    case 3:
                        EditarMision.Editar();
                        break;

                    case 4:
                        EliminarMision.Eliminar();
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
