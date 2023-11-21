

using Planetario.Frontend.Crear.Planetario;
using Planetario.Frontend.Crear.Viajes_Espaciales;
using Planetario.Frontend.Editrar.Planetario;
using Planetario.Frontend.Editrar.Viajes_Espaciales;
using Planetario.Frontend.Eliminar.Planetario;
using Planetario.Frontend.Eliminar.Viajes_Espaciales;
using Planetario.Frontend.Mostrar.Planetario;
using Planetario.Frontend.Mostrar.Viajes_Espaciales;
using Planetario.Frontend.Principal;
using Planetario.Frontend.Principal.Viajes_Espaciales;

namespace NPlanetario.Frontend
{
    public class MenuViajesEspaciales
    {
        private int _opcionUsuario = 9;
        public void MostrarMenu()
        {
            Console.Clear();

            while (_opcionUsuario != 0)
            {
                Console.WriteLine("\nMenu Viajes Espaciales");
                Console.WriteLine("Seleccione un modelo");
                Console.WriteLine("1. Astronauta");
                Console.WriteLine("2. Mision");
                Console.WriteLine("3. Objetivo");
                Console.WriteLine("4. Profesion");

                _opcionUsuario = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (_opcionUsuario)
                {
                    case 1:
                        break;

                    case 2:
                        MenuMision.MostrarMenu();
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
