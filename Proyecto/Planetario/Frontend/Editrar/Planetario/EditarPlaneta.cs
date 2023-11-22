using NPlanetario.LoadBalancing;
using Planetario.Frontend.Mostrar.Planetario;
using Planetario.Frontend.Mostrar.Viajes_Espaciales;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Editrar.Planetario
{
    public class EditarPlaneta
    {
        public static void Editar()
        {
            LoadBalancer _loadBalancer = new LoadBalancer();

            int propiedadEditar;

            int idPlaneta;

            MostrarPlanetas.Mostrar();

            Console.WriteLine("\nDigite el ID del planeta a editar:");

            idPlaneta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Seleccione la propiedad que desea editar:");
            Console.WriteLine("1. Nombre");
            Console.WriteLine("2. Distancia sol");
            Console.WriteLine("3. Periodo orbital");
            Console.WriteLine("4. Velocidad orbital");
            Console.WriteLine("5. Inclinacion orbital");

            propiedadEditar = Convert.ToInt32(Console.ReadLine());

            switch (propiedadEditar)
            {
                case 1:
                    string nuevoNombre;

                    Console.WriteLine("Digite el nuevo nombre que tendra el planeta:");
                    nuevoNombre = Console.ReadLine();

                    Request requestNombre = new Request($"UPDATE Planeta SET Planeta_Nombre = '{nuevoNombre}'", "planetario", "planeta");

                    _loadBalancer.UPDATE(requestNombre, idPlaneta);

                    break;

                case 2:
                    double nuevaDistanciaSol;

                    Console.WriteLine("Digite la nueva distancia al sol que tendrá el planeta:");
                    nuevaDistanciaSol = Convert.ToDouble(Console.ReadLine());

                    Request requestDistanciaSol= new Request($"UPDATE Planeta SET Planeta_DistanciaSol = {nuevaDistanciaSol}", "planetario", "planeta");

                    _loadBalancer.UPDATE(requestDistanciaSol, idPlaneta);
                    break;

                case 3:
                    double nuevoPeriodoOrbital;

                    Console.WriteLine("Digite el nuevo periodo orbital que tendrá el planeta:");
                    nuevoPeriodoOrbital = Convert.ToDouble(Console.ReadLine());

                    Request requestPeriodoOrbital = new Request($"UPDATE Planeta SET Planeta_PeriodoOrbital = {nuevoPeriodoOrbital}", "planetario", "planeta");

                    _loadBalancer.UPDATE(requestPeriodoOrbital, idPlaneta);
                    break;

                case 4:
                    double nuevaVelocidadOrbital;

                    Console.WriteLine("Digite la nueva velocidad orbital que tendrá el planeta:");
                    nuevaVelocidadOrbital = Convert.ToDouble(Console.ReadLine());

                    Request requestVelocidadOrbital = new Request($"UPDATE Planeta SET Planeta_VelocidadOrbital = {nuevaVelocidadOrbital}", "planetario", "planeta");

                    _loadBalancer.UPDATE(requestVelocidadOrbital, idPlaneta);
                    break;

                case 5:
                    double nuevaInclinacionOrbital;

                    Console.WriteLine("Digite la nueva inclinacion orbital que tendrá el planeta:");
                    nuevaInclinacionOrbital = Convert.ToDouble(Console.ReadLine());

                    Request requestInclinacionOrbital = new Request($"UPDATE Planeta SET Planeta_InclinacionOrbital = {nuevaInclinacionOrbital}", "planetario", "planeta");

                    _loadBalancer.UPDATE(requestInclinacionOrbital, idPlaneta);
                    break;

                default:
                    break;
            }
        }
    }
}
