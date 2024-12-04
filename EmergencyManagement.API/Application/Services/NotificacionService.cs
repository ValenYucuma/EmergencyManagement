using Microsoft.AspNetCore.SignalR;

namespace EmergencyManagement.API.Application.Services
{
    public class NotificacionService
    {
        private readonly IHubContext<IncidenteHub> _hubContext;

        public NotificacionService(IHubContext<IncidenteHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task EnviarNotificacion(string mensaje)
        {
            // Enviar la notificación a todos los clientes conectados
            await _hubContext.Clients.All.SendAsync("RecibirNotificacion", mensaje);
        }
    }

}
