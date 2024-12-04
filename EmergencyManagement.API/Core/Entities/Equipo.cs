namespace EmergencyManagement.API.Core.Entities
{
    public class Equipo
    {
        public Guid EquipoId { get; set; }
        public string Nombre { get; set; }
        public Guid TipoEquipoId { get; set; }
        public TipoEquipo TipoEquipo { get; set; }
        public List<Usuario> Miembros { get; set; }
        public List<Incidente> IncidentesAsignados { get; set; }
    }
}
