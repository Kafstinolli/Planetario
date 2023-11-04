using System.Collections;
using System.Diagnostics;

namespace Planetario.Frontend;

public class MenuPlanetario
{
    private int _opcionUsuario = 3;
    public void MostrarMenuPlanetario()
    {
        Console.Clear();
        Console.WriteLine("Menu Planetario");
        Console.WriteLine("Seleccione una opcion: ");

        while (_opcionUsuario != 0)
        {
            Console.WriteLine("1. ");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");
            Console.WriteLine("4. ");
            Console.WriteLine("0. Salir del menu planetario");

            _opcionUsuario = Convert.ToInt32(Console.ReadLine());

            switch (_opcionUsuario)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 0:
                    break;

                default:
                    // MenuPrincipal menuPrincipal = new MenuPrincipal();
                    // menuPrincipal.MostrarMenuPrincipal();
                    break;
            }
        }
    }
}