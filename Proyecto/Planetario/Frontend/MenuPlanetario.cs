using System.Collections;
using System.Diagnostics;

namespace NPlanetario.Frontend;

public class MenuPlanetario
{
    MenuRegistrarSatelite MenuRegistrarSatelite = new MenuRegistrarSatelite();
    private int _opcionUsuario = 3;
    public void MostrarMenu()
    {
        Console.Clear();        

        while (_opcionUsuario != 0)
        {
            Console.WriteLine("Menu Planetario");
            Console.WriteLine("1. ");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");
            Console.WriteLine("4. ");
            Console.WriteLine("0. Salir del menu planetario");
            Console.WriteLine("Seleccione una opcion: ");

            _opcionUsuario = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (_opcionUsuario)
            {
                case 1:
                    MenuRegistrarSatelite.MostrarMenu();
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