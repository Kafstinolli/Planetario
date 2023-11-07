namespace Planetario.Frontend
{
    public class MenuRegistrarSatelite
    {
        private int _opcionUsuario = 9;
        public void MostrarMenu()
        {
            Console.Clear();

            while (_opcionUsuario != 0)
            {
                Console.WriteLine("Agregar Satelite");
                Console.WriteLine("0. Salir del menu planetario");
                Console.WriteLine("Seleccione una opcion: ");

                _opcionUsuario = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

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
}
