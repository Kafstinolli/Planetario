namespace Planetario.Frontend;

public class MenuPrincipal
{
    MenuPlanetario menu1 = new MenuPlanetario();
    MenuViajesEspaciales menu2 = new MenuViajesEspaciales();

    private int _opcionUsuario = 9;

    public void MostrarMenuPrincipal()
    {
        Console.Clear();

        Console.WriteLine("Menu Principal");
        Console.WriteLine("Seleccione una opcion: ");

        while (_opcionUsuario != 0)
        {
            Console.WriteLine("1. Planetario");
            Console.WriteLine("2. Viajes espaciales");
            Console.WriteLine("0. Salir");

            _opcionUsuario = Convert.ToInt32(Console.ReadLine());

            switch (_opcionUsuario)
            {
                case 1:
                    Console.WriteLine("Menu Planetario");
                    menu1.MostrarMenuPlanetario();
                    break;

                case 2:
                    menu2.MostrarMenuViajesEspaciales();
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