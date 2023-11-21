using NPlanetario.LoadBalancing;
using Planetario.Frontend.Mostrar.Planetario;
using Planetario.Frontend.Mostrar.Viajes_Espaciales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Editrar.Viajes_Espaciales
{
    public class EditarMision
    {
        public static void Editar()
        {
            LoadBalancer _loadBalancer = new LoadBalancer();

            int propiedadEditar;

            int idMision;

            MostrarMisiones.Mostrar();

            Console.WriteLine("\nDigite el ID del planetario a editar:");

            idMision = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Seleccione la propiedad que desea eliminar:");
            Console.WriteLine("1. Nombre");
            Console.WriteLine("2. Fecha");
            Console.WriteLine("3. Astronauta");
            Console.WriteLine("4. Objetivo");

            propiedadEditar = Convert.ToInt32(Console.ReadLine());

            switch (propiedadEditar)
            {
                case 1:
                    string nuevoNombre;

                    Console.WriteLine("Digite el nuevo nombre que tendra la mision:");
                    nuevoNombre = Console.ReadLine();

                    Request requestNombre = new Request($"UPDATE Mision SET Mision_Nombre = '{nuevoNombre}'", "viajesEspaciales", "mision");

                    _loadBalancer.UPDATE(requestNombre, idMision);

                    break;
                case 2:
                    DateTime nuevaFecha;

                    Console.WriteLine("Introduzca la fecha de la mision: ");
                    Console.WriteLine("Digite el día en numeros: ");
                    int dia = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite el mes en numeros: ");
                    int mes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite el año en numeros: ");
                    int año = Convert.ToInt32(Console.ReadLine());

                    nuevaFecha = new DateTime(año, mes, dia);

                    Request requestFecha = new Request($"UPDATE Mision SET Mision_Fecha = '{nuevaFecha.ToString("yyyy/MM/dd")}'", "viajesEspaciales", "mision");

                    _loadBalancer.UPDATE(requestFecha, idMision);
                    break;

                case 3:
                    int nuevoAstronauta;

                    Console.WriteLine("Digite el ID del nuevo astronauta lider de la mision:");
                    nuevoAstronauta = Convert.ToInt32(Console.ReadLine());

                    Request requestAastronauta = new Request($"UPDATE Mision SET Mision_AstronautaId = {nuevoAstronauta}", "viajesEspaciales", "mision");

                    _loadBalancer.UPDATE(requestAastronauta, idMision);
                    break;

                case 4:
                    int nuevoObjetivo;

                    Console.WriteLine("Digite el ID del nuevo astronauta lider de la mision:");
                    nuevoObjetivo = Convert.ToInt32(Console.ReadLine());

                    Request requestObjetivo = new Request($"UPDATE Mision SET Mision_ObjetivoId = {nuevoObjetivo}", "viajesEspaciales", "mision");

                    _loadBalancer.UPDATE(requestObjetivo, idMision);
                    break;

                default:
                    break;
            }
        }
    }
}
