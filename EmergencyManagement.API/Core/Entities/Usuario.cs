using EmergencyManagement.API.Core.Enums;

namespace EmergencyManagement.API.Core.Entities
{
    public class Usuario
    {
        public Guid UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string NumeroTelefono { get; set; }
        public RolUsuario Rol { get; set; }
        public Guid? EquipoId { get; set; }
        public Equipo Equipo { get; set; }
    }
}
