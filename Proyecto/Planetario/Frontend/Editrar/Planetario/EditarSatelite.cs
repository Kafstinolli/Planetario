using NPlanetario.LoadBalancing;
using Planetario.Frontend.Mostrar.Planetario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Editrar.Planetario
{
    public class EditarSatelite
    {
        public static void Editar()
        {
            LoadBalancer _loadBalancer = new LoadBalancer();

            int propiedadEditar;

            int idSatelite;

            MostrarSatelites.Mostrar();

            Console.WriteLine("\nDigite el ID del satelite a editar:");

            idSatelite = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Seleccione la propiedad que desea editar:");
            Console.WriteLine("1. Nombre");
            Console.WriteLine("2. Excentricidad");
            Console.WriteLine("3. Periodo orbital");
            Console.WriteLine("4. Inclinacion orbital");

            propiedadEditar = Convert.ToInt32(Console.ReadLine());

            switch (propiedadEditar)
            {
                case 1:
                    string nuevoNombre;

                    Console.WriteLine("Digite el nuevo nombre que tendra el satelite:");
                    nuevoNombre = Console.ReadLine();

                    Request requestNombre = new Request($"UPDATE Satelite SET Satelite_Nombre = '{nuevoNombre}'", "planetario", "satelite");

                    _loadBalancer.UPDATE(requestNombre, idSatelite);

                    break;

                case 2:
                    double nuevaExcentricidad;

                    Console.WriteLine("Digite la nueva excentricidad que tendrá el satelite:");
                    nuevaExcentricidad = Convert.ToDouble(Console.ReadLine());

                    Request requestDistanciaSol = new Request($"UPDATE Satelite SET Satelite_Excentricidad = {nuevaExcentricidad}", "planetario", "satelite");

                    _loadBalancer.UPDATE(requestDistanciaSol, idSatelite);
                    break;

                case 3:
                    double nuevoPeriodoOrbital;

                    Console.WriteLine("Digite el nuevo periodo orbital que tendrá el satelite:");
                    nuevoPeriodoOrbital = Convert.ToDouble(Console.ReadLine());

                    Request requestPeriodoOrbital = new Request($"UPDATE Satelite SET Satelite_PeriodoOrbital = {nuevoPeriodoOrbital}", "planetario", "satelite");

                    _loadBalancer.UPDATE(requestPeriodoOrbital, idSatelite);
                    break;

                case 4:
                    double nuevaInclinacionOrbital;

                    Console.WriteLine("Digite la nueva inclinacion orbital que tendrá el satelite:");
                    nuevaInclinacionOrbital = Convert.ToDouble(Console.ReadLine());

                    Request requestVelocidadOrbital = new Request($"UPDATE Satelite SET Satelite_InclinacionOrbital = {nuevaInclinacionOrbital}", "planetario", "satelite");

                    _loadBalancer.UPDATE(requestVelocidadOrbital, idSatelite);
                    break;

                default:
                    break;
            }
        }
    }
}
