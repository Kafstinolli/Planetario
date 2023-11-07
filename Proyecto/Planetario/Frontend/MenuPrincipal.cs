using System;

namespace Planetario.Frontend;

public class MenuPrincipal
{
    private int _opcionUsuario = 9;

    public void MostrarMenuPrincipal()
    {
        Console.Clear();

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

            _opcionUsuario = Convert.ToInt32(Console.ReadLine());

            switch (_opcionUsuario)
            {
                case 1:
                    Console.WriteLine("Menu Planetario");
                    break;

                case 2:
                    Console.WriteLine("Menu Viajes Espaciales");
                    break;

                case 0:
                    Console.WriteLine("Cerrando... ");
                    break;

                default:
                    //  MostrarMenuPrincipal();
                    Console.WriteLine("Seleccione una opción valida");
                    break;
            }
        }
    }
}