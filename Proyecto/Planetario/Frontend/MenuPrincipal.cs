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

<<<<<<< HEAD
        Console.WriteLine("           ********************************************* ");
        Console.WriteLine("           ****   BIENVENIDO AL SISTEMA C.A.S.M.E   **** ");
        var emojis = new Emoji[] { new Emoji("\U00002B05"), new Emoji("\U000027A1") };
        Console.WriteLine("           ****                                     **** ");
        Console.WriteLine("           ********************************************* ");
        Console.WriteLine("        Seleccione una opcion:                ");
        while (_opcionUsuario != 0)
        {
            Console.WriteLine("    1. Planetario");
            Console.WriteLine("    2. Viajes espaciales");
            Console.WriteLine("    0. Salir");
=======
        while (_opcionUsuario != 0)
        {
            Console.WriteLine("Menu Principal");
            Console.WriteLine("1. Planetario");
            Console.WriteLine("2. Viajes espaciales");
            Console.WriteLine("0. Salir");
            Console.WriteLine("Seleccione una opcion: ");

>>>>>>> 7c2b1644c55ecd9767183d4ea49aa1a0028af3e5

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
                    //  MostrarMenuPrincipal();
                    Console.Clear();
                    Console.WriteLine("Seleccione una opción valida");
                    break;
            }
        }
    }
}