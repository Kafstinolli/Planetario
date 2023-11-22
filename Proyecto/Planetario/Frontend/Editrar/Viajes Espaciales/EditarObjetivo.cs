using NPlanetario.LoadBalancing;
using Planetario.Frontend.Mostrar.Viajes_Espaciales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Editrar.Viajes_Espaciales
{
    public class EditarObjetivo
    {
        public static void Editar()
        {
            LoadBalancer _loadBalancer = new LoadBalancer();

            int propiedadEditar;

            int idObjetivo;

            MostrarObjetivos.Mostrar();

            Console.WriteLine("\nDigite el ID del objetivo a editar:");

            idObjetivo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Seleccione la propiedad que desea editar:");
            Console.WriteLine("1. Nombre");

            propiedadEditar = Convert.ToInt32(Console.ReadLine());

            switch (propiedadEditar)
            {
                case 1:
                    string nuevoNombre;

                    Console.WriteLine("Digite el nuevo nombre que tendra el objetivo:");
                    nuevoNombre = Console.ReadLine();

                    Request requestNombre = new Request($"UPDATE Objetivo SET Objetivo_Nombre = '{nuevoNombre}'", "viajesEspaciales", "objetivo");

                    _loadBalancer.UPDATE(requestNombre, idObjetivo);
                    break;

                default:
                    break;
            }
        }
    }
}
