using Planetario.Data.ViajesEspaciales;
using Planetario.Models.ViajesEspaciales;

namespace Planetario.Backend.ViajesEspaciales
{
    public class ViajesEspacialesController
    {
        public void Add(ViajesEspacialesServer viajesEspacialesServer, string query)
        {
            Console.Clear();

            viajesEspacialesServer.CreateMision(query);

            Console.WriteLine("Se creó la misión correctamente");
        }
        public void Show(ViajesEspacialesServer viajesEspacialesServer, string query)
        {
            Console.Clear();

            List<Mision> misiones = viajesEspacialesServer.GetAllMisiones(query);
           
            foreach(Mision mision in misiones)
            {
                Console.WriteLine($"| {mision.IdMision} | {mision.NombreMision} | {mision.FechaMision} | {mision.IdAstronauta} | {mision.IdObjetivo} |");
            }
        }
    }
}
