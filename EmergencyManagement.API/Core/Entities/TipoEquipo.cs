namespace EmergencyManagement.API.Core.Entities
{
    public class TipoEquipo
    {
        public Guid TipoEquipoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Equipo> Equipos { get; set; }
    }
}
