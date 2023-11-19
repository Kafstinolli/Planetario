using NPlanetario.Backend.BPlanetario;
using NPlanetario.Data.DPlanetario;
using NPlanetario.LoadBalancing;
using System.Collections;
using System.Diagnostics;

namespace NPlanetario.Frontend;

public class MenuPlanetario
{
    private LoadBalancer _loadBalancer = new LoadBalancer();

    private int _opcionUsuario = 9;
    public void MostrarMenu()
    {
        Console.Clear();        

        while (_opcionUsuario != 0)
        {
            Console.WriteLine("Menu Planetario");
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
                    break;

                case 2:
                    Request _request = new Request("SELECT  Planetario_Id, Planetario_Nombre FROM Planetario", "planetario", "planetario");
                    _loadBalancer.SELECT(_request);
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