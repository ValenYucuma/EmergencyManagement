namespace EmergencyManagement.API.Core.Entities
{
    public class MensajeTiempoReal
    {
        public Guid MensajeId { get; set; }
        public DateTime FechaHora { get; set; }
        public Guid EmisorUsuarioId { get; set; }
        public Guid? ReceptorUsuarioId { get; set; }
        public string Contenido { get; set; }
        public Guid? IncidenteId { get; set; }
    }
}
