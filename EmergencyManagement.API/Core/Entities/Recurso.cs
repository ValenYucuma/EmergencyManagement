namespace EmergencyManagement.API.Core.Entities
{
    public class Recurso
    {
        public Guid RecursoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CantidadDisponible { get; set; }
        public string Ubicacion { get; set; }
        public Guid? IncidenteIdAsignado { get; set; }
        public Incidente Incidente { get; set; }
    }
}
