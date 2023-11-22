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
    public class MenuObjetivo
    {
        public static void MostrarMenu()
        {
            int _opcionUsuario = 9;

            Console.Clear();

            while (_opcionUsuario != 0)
            {
                Console.WriteLine("\nMenu Objetivo");
                Console.WriteLine("Seleccione una opcion: ");
                Console.WriteLine("1. Crear objetivo");
                Console.WriteLine("2. Visualizar objetivos");
                Console.WriteLine("3. Editar objetivo");
                Console.WriteLine("4. Eliminar objetivo");
                Console.WriteLine("0. Salir del menu de objetivos");
                Console.WriteLine("Seleccione una opcion: ");

                _opcionUsuario = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (_opcionUsuario)
                {
                    case 1:
                        CrearObjetivo.Crear();
                        break;

                    case 2:
                        MostrarObjetivos.Mostrar();
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
