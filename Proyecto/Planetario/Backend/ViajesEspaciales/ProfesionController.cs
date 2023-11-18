using NPlanetario.Data.ViajesEspaciales;
using NPlanetario.Models.ViajesEspaciales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPlanetario.Backend.ViajesEspaciales
{
    public class ProfesionController
    {
        public void Add(ViajesEspacialesServer viajesEspacialesServer, string query)
        {
            Console.Clear();

            viajesEspacialesServer.CreateProfesion(query);

            Console.WriteLine("Se creó la profesion correctamente");
        }
        public void Show(ViajesEspacialesServer viajesEspacialesServer, string query)
        {
            Console.Clear();

            List<Profesion> Profesiones = viajesEspacialesServer.ReadProfesiones(query);

            foreach (Profesion Profesion in Profesiones)
            {
                Console.WriteLine($"| {Profesion.Id} | {Profesion.Nombre} |");
            }
        }

        public void Edit(ViajesEspacialesServer viajesEspacialesServer, string query, int id)
        {
            Console.Clear();

            query += $" WHERE Profesion_Id = {id}";

            viajesEspacialesServer.UpdateProfesion(query);

            Console.WriteLine("Se editó la profesion correctamente");
        }

        public void Remove(ViajesEspacialesServer viajesEspacialesServer, string query, int id)
        {
            Console.Clear();

            query += $" WHERE Profesion_Id = {id}";

            viajesEspacialesServer.DeleteProfesion(query);

            Console.WriteLine("Se eliminó la profesion correctamente");
        }
    }
}
