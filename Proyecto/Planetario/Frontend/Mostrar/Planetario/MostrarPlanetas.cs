using NPlanetario.LoadBalancing;
using Planetario.Frontend.Crear.Planetario;
using Planetario.Frontend.Editrar.Planetario;
using Planetario.Frontend.Eliminar.Planetario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Mostrar.Planetario
{
    public class MostrarPlanetas
    {
        public static void MostrarMenu()
        {
            int _opcionUsuario = 9;

            Console.Clear();

            while (_opcionUsuario != 0)
            {
                Console.WriteLine("\nMenu Mostrar Planeta");
                Console.WriteLine("1. Visualizar todos los planetas");
                Console.WriteLine("2. Consultar los planetas con una distancia media al sol menor que la distancia dada");
                Console.WriteLine("3. Consultar los planetas con una inclinación orbital menor a la del planeta seleccionado");
                Console.WriteLine("0. Salir del menu mostrar planeta");
                Console.WriteLine("Seleccione una opcion: ");

                _opcionUsuario = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (_opcionUsuario)
                {
                    case 1:
                        Mostrar();
                        break;

                    case 2:
                        MostrarFiltroDistanciaSol();
                        break;

                    case 3:
                        MostrarFiltroInclinacionOrbital();
                        break;

                    case 0:
                        break;

                    default:
                        MostrarMenu();
                        break;
                }
            }
        }

        public static void Mostrar()
        {
            LoadBalancer _loadBalancer = new LoadBalancer();

            Request request = new Request("SELECT Planeta_Id, Planeta_Nombre, Planeta_DistanciaSol, Planeta_PeriodoOrbital, Planeta_VelocidadOrbital, Planeta_InclinacionOrbital FROM Planeta", "planetario", "planeta");
            _loadBalancer.SELECT(request);
        }

        private static void MostrarFiltroDistanciaSol()
        {
            LoadBalancer _loadBalancer = new LoadBalancer();

            int distanciaSolFiltro;

            Console.WriteLine("Digite la distancia por la que va a filtrar la lista de planetas");
            distanciaSolFiltro = Convert.ToInt32(Console.ReadLine());

            Request request = new Request($"SELECT Planeta_Id, Planeta_Nombre, Planeta_DistanciaSol, Planeta_PeriodoOrbital, Planeta_VelocidadOrbital, Planeta_InclinacionOrbital FROM Planeta WHERE Planeta_DistanciaSol < {distanciaSolFiltro}", "planetario", "planeta");
            _loadBalancer.SELECT(request);
        }

        private static void MostrarFiltroInclinacionOrbital()
        {
            LoadBalancer _loadBalancer = new LoadBalancer();

            double inclinacionOrbitalFiltro;

            Console.WriteLine("Digite la inclinacion orbital por la que va a filtrar la lista de planetas");
            inclinacionOrbitalFiltro = Convert.ToDouble(Console.ReadLine());

            Request request = new Request($"SELECT Planeta_Id, Planeta_Nombre, Planeta_DistanciaSol, Planeta_PeriodoOrbital, Planeta_VelocidadOrbital, Planeta_InclinacionOrbital FROM Planeta WHERE Planeta_InclinacionOrbital < {inclinacionOrbitalFiltro}", "planetario", "planeta");
            _loadBalancer.SELECT(request);
        }
    }
}
