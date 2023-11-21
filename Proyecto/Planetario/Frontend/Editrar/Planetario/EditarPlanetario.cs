using NPlanetario.LoadBalancing;
using Planetario.Frontend.Mostrar.Planetario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Editrar.Planetario
{
    public class EditarPlanetario
    {
        public static void Editar()
        {
            LoadBalancer _loadBalancer = new LoadBalancer();

            int propiedadEditar;

            int idPlanetario;

            MostrarPlanetarios.Mostrar();

            Console.WriteLine("\nDigite el ID del planetario a editar:");

            idPlanetario = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Seleccione la propiedad que desea eliminar:");
            Console.WriteLine("1. Nombre");

            propiedadEditar = Convert.ToInt32(Console.ReadLine());

            switch(propiedadEditar)
            {
                case 1:
                    string nuevoNombre;

                    Console.WriteLine("Digite el nuevo nombre que tendra el planetario:");
                    nuevoNombre = Console.ReadLine();

                    Request request = new Request($"UPDATE Planetario SET Planetario_Nombre = '{nuevoNombre}'", "planetario", "planetario");

                    _loadBalancer.UPDATE(request, idPlanetario);
                    break;
                default:
                    break;
            }
        }
    }
}
