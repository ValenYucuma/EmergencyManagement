namespace EmergencyManagement.API.Core.Entities
{
    public class DatosTelemetria
    {
        public Guid TelemetriaId { get; set; }
        public DateTime FechaHora { get; set; }
        public string Fuente { get; set; }
        public dynamic Datos { get; set; } // Usar JSON para almacenar datos dinámicos
        public Guid? IncidenteId { get; set; }
    }
}
