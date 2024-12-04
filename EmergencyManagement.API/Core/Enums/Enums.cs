namespace EmergencyManagement.API.Core.Enums
{
    public enum NivelSeveridad
    {
        Bajo,
        Medio,
        Alto,
        Crítico
    }

    public enum EstadoIncidente
    {
        Abierto,
        EnProgreso,
        Resuelto,
        Cerrado
    }

    public enum RolUsuario
    {
        Administrador,
        Coordinador,
        MiembroEquipo
    }
}
