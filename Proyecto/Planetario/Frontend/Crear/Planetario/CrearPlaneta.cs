using NPlanetario.LoadBalancing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Crear.Planetario
{
    public class CrearPlaneta
    {
        public static void Crear()
        {
            LoadBalancer loadBalancer = new LoadBalancer();

            string nombrePlaneta;
            double distancialSol, periodoOrbital, velocidadOrbital, inclinacionOrbital;

            Console.WriteLine("Introduzca el nombre del planeta");
            nombrePlaneta = Console.ReadLine();

            Console.WriteLine("Digite la distancia que tiene el planeta con respecto al sol");
            distancialSol = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite el periodo orbital que tiene el planeta");
            periodoOrbital = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite la velocidad orbital que tiene el planeta");
            velocidadOrbital = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite la inclinacion orbital que tiene el planeta");
            inclinacionOrbital = Convert.ToDouble(Console.ReadLine());

            Request request = new Request($"INSERT INTO Planeta (Planeta_Nombre, Planeta_DistanciaSol, Planeta_PeriodoOrbital, Planeta_VelocidadOrbital, Planeta_InclinacionOrbital ) VALUES ('{nombrePlaneta}', {distancialSol}, {periodoOrbital}, {velocidadOrbital}, {inclinacionOrbital})", "planetario", "planeta");
            loadBalancer.INSERT(request);
        }
    }
}
