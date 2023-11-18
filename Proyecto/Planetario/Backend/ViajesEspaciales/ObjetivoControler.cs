using NPlanetario.Data.ViajesEspaciales;
using NPlanetario.Models.ViajesEspaciales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPlanetario.Backend.ViajesEspaciales
{
    public class ObjetivoControler
    {
        public void Add(ViajesEspacialesServer viajesEspacialesServer, string query)
        {
            Console.Clear();

            viajesEspacialesServer.CreateObjetivo(query);

            Console.WriteLine("Se creó la objetivo correctamente");
        }

        public void Show(ViajesEspacialesServer viajesEspacialesServer, string query)
        {
            Console.Clear();

            List<Objetivo> Objetivoes = viajesEspacialesServer.ReadObjetivos(query);

            foreach (Objetivo Objetivo in Objetivoes)
            {
                Console.WriteLine($"| {Objetivo.Id} | {Objetivo.Nombre} |");
            }
        }

        public void Edit(ViajesEspacialesServer viajesEspacialesServer, string query, int id)
        {
            Console.Clear();

            query += $" WHERE Objetivo_Id = {id}";

            viajesEspacialesServer.UpdateObjetivo(query);

            Console.WriteLine("Se editó la objetivo correctamente");
        }

        public void Remove(ViajesEspacialesServer viajesEspacialesServer, string query, int id)
        {
            Console.Clear();

            query += $" WHERE Objetivo_Id = {id}";

            viajesEspacialesServer.DeleteObjetivo(query);

            Console.WriteLine("Se eliminó la objetivo correctamente");
        }
    }
}
