using NPlanetario.LoadBalancing;
using Planetario.Frontend.Mostrar.Viajes_Espaciales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Editrar.Viajes_Espaciales
{
    public class EditarAstronauta
    {
        public static void Editar()
        {
            LoadBalancer _loadBalancer = new LoadBalancer();

            int propiedadEditar;

            int idAstronauta;

            MostrarAstronautas.Mostrar();

            Console.WriteLine("\nDigite el ID del astronauta a editar:");

            idAstronauta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Seleccione la propiedad que desea editar:");
            Console.WriteLine("1. Nombre");
            Console.WriteLine("2. Profesion");

            propiedadEditar = Convert.ToInt32(Console.ReadLine());

            switch (propiedadEditar)
            {
                case 1:
                    string nuevoNombre;

                    Console.WriteLine("Digite el nuevo nombre que tendra el astronauta:");
                    nuevoNombre = Console.ReadLine();

                    Request requestNombre = new Request($"UPDATE Astronauta SET Astronauta_Nombre = '{nuevoNombre}'", "viajesEspaciales", "astronauta");

                    _loadBalancer.UPDATE(requestNombre, idAstronauta);
                    break;

                case 2:
                    int nuevaProfesion;

                    Console.WriteLine("Digite el ID de la nueva profesion del astronauta: ");
                    nuevaProfesion = Convert.ToInt32(Console.ReadLine());

                    Request requestFecha = new Request($"UPDATE Astronauta SET Astronauta_ProfesionId = {nuevaProfesion}", "viajesEspaciales", "astronauta");

                    _loadBalancer.UPDATE(requestFecha, idAstronauta);
                    break;

                default:
                    break;
            }
        }
    }
}
