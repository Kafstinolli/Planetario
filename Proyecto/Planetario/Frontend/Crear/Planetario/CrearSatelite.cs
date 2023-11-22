using NPlanetario.LoadBalancing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sateliterio.Frontend.Crear.Sateliterio
{
    public class CrearSatelite
    {
        public static void Crear()
        {
            LoadBalancer loadBalancer = new LoadBalancer();

            string nombreSatelite;
            double excentricidad, periodoOrbital, inclinacionOrbital;

            Console.WriteLine("Introduzca el nombre del satelite");
            nombreSatelite = Console.ReadLine();

            Console.WriteLine("Digite la excentricidad que tiene el satelite");
            excentricidad = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite el periodo orbital que tiene el satelite");
            periodoOrbital = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite la inclinacion orbital que tiene el satelite");
            inclinacionOrbital = Convert.ToDouble(Console.ReadLine());

            Request request = new Request($"INSERT INTO Satelite (Satelite_Nombre, Satelite_Excentricidad, Satelite_PeriodoOrbital, Satelite_InclinacionOrbital) VALUES ('{nombreSatelite}', {excentricidad}, {periodoOrbital}, {inclinacionOrbital})", "planetario", "satelite");
            loadBalancer.INSERT(request);
        }
    }
}
