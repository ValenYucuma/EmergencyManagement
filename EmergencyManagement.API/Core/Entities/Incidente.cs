using EmergencyManagement.API.Core.Enums;

namespace EmergencyManagement.API.Core.Entities
{
    public class Incidente
    {
        public Guid IncidenteId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public Guid TipoIncidenteId { get; set; }
        public NivelSeveridad NivelSeveridad { get; set; }
        public EstadoIncidente Estado { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public string Ubicacion { get; set; }
        public List<Equipo> EquiposAsignados { get; set; }

    }
}
