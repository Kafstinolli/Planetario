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

            List<Mision> misiones = viajesEspacialesServer.ReadMisiones(query);
           
            foreach(Mision mision in misiones)
            {
                Console.WriteLine($"| {mision.IdMision} | {mision.NombreMision} | {mision.FechaMision} | {mision.IdAstronauta} | {mision.IdObjetivo} |");
            }
        }

        public void Edit(ViajesEspacialesServer viajesEspacialesServer, string query, int id)
        {
            Console.Clear();

            query += $" WHERE Mision_Id = {id}";

            viajesEspacialesServer.UpdateMision(query);

            Console.WriteLine("Se editó la misión correctamente");
        }

        public void Remove(ViajesEspacialesServer viajesEspacialesServer, string query, int id)
        {
            Console.Clear();

            query += $" WHERE Mision_Id = {id}";

            viajesEspacialesServer.DeleteMision(query);

            Console.WriteLine("Se eliminó la misión correctamente");
        }
    }
}
