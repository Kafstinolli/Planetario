using NPlanetario.LoadBalancing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Crear.Viajes_Espaciales
{
    public class CrearMision
    {
        public static void Crear()
        {
            LoadBalancer loadBalancer = new LoadBalancer();

            string nombreMision;
            DateTime misionFecha;
            int astronautaId, objetivoId;

            Console.WriteLine("Digite el nombre de la mision:");
            nombreMision = Console.ReadLine();

            Console.WriteLine("Introduzca la fecha de la mision: ");
            Console.WriteLine("Digite el día en numeros: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el mes en numeros: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el año en numeros: ");
            int año = Convert.ToInt32(Console.ReadLine());

            misionFecha = new DateTime(año, mes, dia);

            Console.WriteLine("Digite el ID del astronauta lider de la mision:");
            astronautaId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el ID del objetivo de la mision: ");
            objetivoId = Convert.ToInt32(Console.ReadLine());

            Request request = new Request($"INSERT INTO Mision (Mision_Nombre, Mision_Fecha, Mision_AstronautaId, Mision_ObjetivoId) VALUES ('{nombreMision}', '{misionFecha.ToString("yyyy/MM/dd")}', {astronautaId}, {objetivoId})", "viajesEspaciales", "mision");
            loadBalancer.INSERT(request);
        }
    }
}