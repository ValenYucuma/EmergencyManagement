namespace EmergencyManagement.API.Core.Entities
{
    public class TipoIncidente
    {
        public Guid TipoIncidenteId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Incidente> Incidentes { get; set; }
    }
}
