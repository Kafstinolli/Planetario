using System;

namespace Planetario.Frontend;

public class MenuPrincipal
{
    MenuPlanetario menuPlanetario = new MenuPlanetario();
    MenuViajesEspaciales menuViajesEspaciales = new MenuViajesEspaciales();

    private int _opcionUsuario = 9;

    public void MostrarMenuPrincipal()
    {
        Console.Clear();
        Console.WriteLine("Menu Principal");

        while (_opcionUsuario != 0)
        {
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
                    menuViajesEspaciales.MostrarMenu();
                    break;

                case 0:
                    Console.WriteLine("Cerrando... ");
                    break;

                default:
                    MostrarMenuPrincipal();
                    Console.WriteLine("Seleccione una opción valida");
                    break;
            }
        }
    }
}