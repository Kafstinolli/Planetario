using NPlanetario.Backend.BPlanetario;
using NPlanetario.Data.DPlanetario;
using NPlanetario.LoadBalancing;
using Planetario.Frontend.Crear.Planetario;
using Planetario.Frontend.Eliminar.Planetario;
using Planetario.Frontend.Mostrar.Planetario;
using System.Collections;
using System.Diagnostics;

namespace Planetario.Frontend.Principal.Planetario;

public class MenuPlanetario
{
    private int _opcionUsuario = 9;
    public void MostrarMenu()
    {
        Console.Clear();

        while (_opcionUsuario != 0)
        {
            Console.WriteLine("\nMenu Planetario");
            Console.WriteLine("1. Crear planetario");
            Console.WriteLine("2. Visualizar planetarios");
            Console.WriteLine("3. Editar planetario");
            Console.WriteLine("4. Eliminar planetario");
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
                    break;

                case 4:
                    EliminarPlanetario.Eliminar();
                    break;

                case 0:
                    MenuPrincipal.MostrarMenu();
                    break;

                default:
                    // MenuPrincipal menuPrincipal = new MenuPrincipal();
                    // menuPrincipal.MostrarMenuPrincipal();
                    break;
            }
        }
    }
}