using System;
using NPlanetario.Frontend;
using Planetario.Frontend.Principal.Planetario;

namespace Planetario.Frontend.Principal;

public class MenuPrincipal
{

    private static int _opcionUsuario = 9;

    public static void MostrarMenu()
    {
        MenuPlanetario menuPlanetario = new MenuPlanetario();

        Console.Clear();

        while (_opcionUsuario != 0)
        {
            Console.WriteLine("\nMenu Principal");
            Console.WriteLine("1. Planetario");
            Console.WriteLine("2. Viajes espaciales");
            Console.WriteLine("0. Salir");
            Console.WriteLine("Seleccione una opcion: ");

            _opcionUsuario = Convert.ToInt32(Console.ReadLine());

            switch (_opcionUsuario)
            {
                case 1:
                    menuPlanetario.MostrarMenu();
                    break;

                case 2:
                    MenuViajesEspaciales.MostrarMenu();
                    break;

                case 0:
                    Console.WriteLine("Cerrando... ");
                    break;

                default:
                    MostrarMenu();
                    break;
            }
        }
    }
}
