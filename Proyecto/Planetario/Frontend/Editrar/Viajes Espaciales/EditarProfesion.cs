using NPlanetario.LoadBalancing;
using Planetario.Frontend.Mostrar.Viajes_Espaciales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Editrar.Viajes_Espaciales
{
    public class EditarProfesion
    {
        public static void Editar()
        {
            LoadBalancer _loadBalancer = new LoadBalancer();

            int propiedadEditar;

            int idProfesion;

            MostrarProfesion.Mostrar();

            Console.WriteLine("\nDigite el ID de la profesion a editar:");

            idProfesion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Seleccione la propiedad que desea editar:");
            Console.WriteLine("1. Nombre");

            propiedadEditar = Convert.ToInt32(Console.ReadLine());

            switch (propiedadEditar)
            {
                case 1:
                    string nuevoNombre;

                    Console.WriteLine("Digite el nuevo nombre que tendra la profesion:");
                    nuevoNombre = Console.ReadLine();

                    Request requestNombre = new Request($"UPDATE Profesion SET Profesion_Nombre = '{nuevoNombre}'", "viajesEspaciales", "profesion");

                    _loadBalancer.UPDATE(requestNombre, idProfesion);
                    break;

                default:
                    break;
            }
        }
    }
}
