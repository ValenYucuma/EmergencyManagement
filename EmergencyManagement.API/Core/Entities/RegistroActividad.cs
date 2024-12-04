namespace EmergencyManagement.API.Core.Entities
{
    public class RegistroActividad
    {
        public Guid RegistroId { get; set; }
        public DateTime FechaHora { get; set; }
        public Guid UsuarioId { get; set; }
        public string Accion { get; set; }
        public string Detalle { get; set; }
        public Guid? IncidenteId { get; set; }
    }
}
