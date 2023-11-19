using NPlanetario.Backend.BPlanetario;
using NPlanetario.Data.DPlanetario;
using NPlanetario.LoadBalancing;
using Planetario.Frontend;
using System.Collections;
using System.Diagnostics;

namespace NPlanetario.Frontend;

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
                    break;

                case 2:
                    MostrarPlanetarios.Mostrar();
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