using Planetario.Data.ViajesEspaciales;
using Planetario.Models.ViajesEspaciales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Backend.ViajesEspaciales
{
    public class AstronataController
    {
        public void Add(ViajesEspacialesServer viajesEspacialesServer, string query)
        {
            Console.Clear();

            viajesEspacialesServer.CreateAstronauta(query);

            Console.WriteLine("Se creó la astronauta correctamente");
        }
        public void Show(ViajesEspacialesServer viajesEspacialesServer, string query)
        {
            Console.Clear();

            List<Astronauta> Astronautaes = viajesEspacialesServer.ReadAstronautas(query);

            foreach (Astronauta Astronauta in Astronautaes)
            {
                Console.WriteLine($"| {Astronauta.Id} | {Astronauta.Nombre} | {Astronauta.IdProfesion} |");
            }
        }

        public void Edit(ViajesEspacialesServer viajesEspacialesServer, string query, int id)
        {
            Console.Clear();

            query += $" WHERE Astronauta_Id = {id}";

            viajesEspacialesServer.UpdateAstronauta(query);

            Console.WriteLine("Se editó la astronauta correctamente");
        }

        public void Remove(ViajesEspacialesServer viajesEspacialesServer, string query, int id)
        {
            Console.Clear();

            query += $" WHERE Astronauta_Id = {id}";

            viajesEspacialesServer.DeleteAstronauta(query);

            Console.WriteLine("Se eliminó la astronauta correctamente");
        }
    }
}
