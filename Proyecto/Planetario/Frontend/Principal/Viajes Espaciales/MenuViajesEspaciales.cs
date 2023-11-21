

using Planetario.Frontend.Crear.Planetario;
using Planetario.Frontend.Crear.Viajes_Espaciales;
using Planetario.Frontend.Editrar.Planetario;
using Planetario.Frontend.Eliminar.Planetario;
using Planetario.Frontend.Mostrar.Planetario;
using Planetario.Frontend.Mostrar.Viajes_Espaciales;
using Planetario.Frontend.Principal;

namespace NPlanetario.Frontend
{
    public class MenuViajesEspaciales
    {
        private int _opcionUsuario = 3;
        public void MostrarMenu()
        {
            Console.Clear();

            while (_opcionUsuario != 0)
            {
                Console.WriteLine("\nMenu Viajes Espaciales");
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
