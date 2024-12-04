using EmergencyManagement.API.Core.Enums;
using MediatR;

namespace EmergencyManagement.API.Application.Commands
{
  
        public record CrearIncidenteCommand(string Titulo, string Descripcion, Guid TipoIncidenteId, NivelSeveridad NivelSeveridad) : IRequest<Guid>;

}
