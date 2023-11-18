namespace NPlanetario.Models.ViajesEspaciales
{
    public class Mision
    {
        public int IdMision { get; set; }
        public string NombreMision { get; set; }
        public DateTime FechaMision { get; set; }
        public int IdAstronauta { get; set; }
        public int IdObjetivo { get; set; }

        public Mision(int idMision, string nombreMision, DateTime fechaMision, int idAstronauta, int idObjetivo)
        {
            IdMision = idMision;
            NombreMision = nombreMision;
            FechaMision = fechaMision;
            IdAstronauta = idAstronauta;
            IdObjetivo = idObjetivo;
        }
    }
}
