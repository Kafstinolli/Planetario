using Planetario.Frontend.Crear.Planetario;
using Planetario.Frontend.Editrar.Planetario;
using Planetario.Frontend.Eliminar.Planetario;
using Planetario.Frontend.Mostrar.Planetario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Principal.Planetario
{
    public class MenuSatelite
    {
        public static void MostrarMenu()
        {
            int _opcionUsuario = 9;

            Console.Clear();

            while (_opcionUsuario != 0)
            {
                Console.WriteLine("\nMenu Satelite");
                Console.WriteLine("1. Crear satelite");
                Console.WriteLine("2. Visualizar satelites");
                Console.WriteLine("3. Editar satelite");
                Console.WriteLine("4. Eliminar satelite");
                Console.WriteLine("0. Salir del menu satelite");
                Console.WriteLine("Seleccione una opcion: ");

                _opcionUsuario = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (_opcionUsuario)
                {
                    case 1:
                        break;

                    case 2:
                        MostrarSatelites.Mostrar();
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
