using NPlanetario.Backend.BPlanetario;
using NPlanetario.Data.DPlanetario;
using NPlanetario.LoadBalancing;
using Planetario.Frontend.Crear.Planetario;
using Planetario.Frontend.Editrar.Planetario;
using Planetario.Frontend.Eliminar.Planetario;
using Planetario.Frontend.Mostrar.Planetario;
using Planetario.Frontend.Relaciones.Planetario;
using System.Collections;
using System.Diagnostics;

namespace Planetario.Frontend.Principal.Planetario;

public class MenuPlanetario
{
    public static void MostrarMenu()
    {
        int _opcionUsuario = 9;

        Console.Clear();

        while (_opcionUsuario != 0)
        {
            Console.WriteLine("\nMenu Planetario");
            Console.WriteLine("1. Crear planetario");
            Console.WriteLine("2. Visualizar planetarios");
            Console.WriteLine("3. Editar planetario");
            Console.WriteLine("4. Eliminar planetario");
            Console.WriteLine("5. Asignar satelite natural a planetario");
            Console.WriteLine("6. Asignar planeta a planetario");
            Console.WriteLine("0. Salir del menu planetario");
            Console.WriteLine("Seleccione una opcion: ");

            _opcionUsuario = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (_opcionUsuario)
            {
                case 1:
                    CrearPlanetario.Crear();
                    break;

                case 2:
                    MostrarPlanetarios.Mostrar();
                    break;

                case 3:
                    EditarPlanetario.Editar();
                    break;

                case 4:
                    EliminarPlanetario.Eliminar();
                    break;

                case 5:
                    PlanetarioSatelite.MostrarMenu();
                    break;

                case 6:
                    PlanetarioPlaneta.MostrarMenu();
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