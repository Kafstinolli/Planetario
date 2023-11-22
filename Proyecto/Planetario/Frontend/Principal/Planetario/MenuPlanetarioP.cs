using Planetario.Frontend.Principal.Viajes_Espaciales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Principal.Planetario
{
    public class MenuPlanetarioP
    {
        public static void MostrarMenu()
        {
            int _opcionUsuario = 9;

            Console.Clear();

            while (_opcionUsuario != 0)
            {
                Console.WriteLine("\nMenu Planetario");
                Console.WriteLine("Seleccione un modelo");
                Console.WriteLine("1. Planeta");
                Console.WriteLine("2. Planetario");
                Console.WriteLine("3. Satelite");
                Console.WriteLine("0. Salir del menu");

                _opcionUsuario = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (_opcionUsuario)
                {
                    case 1:
                        MenuPlaneta.MostrarMenu();
                        break;

                    case 2:
                        MenuPlanetario.MostrarMenu();
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
