using EmergencyManagement.API.Application.Commands;
using EmergencyManagement.API.Core.Entities;
using EmergencyManagement.API.Core.Enums;
using EmergencyManagement.API.Core.Interfaces;
using MediatR;

namespace EmergencyManagement.API.Application.Handlers
{
 
    public class CrearIncidenteHandler : IRequestHandler<CrearIncidenteCommand, Guid>
    {
        private readonly IIncidenteRepository _repository;

        public CrearIncidenteHandler(IIncidenteRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CrearIncidenteCommand request, CancellationToken cancellationToken)
        {
            var incidente = new Incidente
            {
                IncidenteId = Guid.NewGuid(),
                Titulo = request.Titulo,
                Descripcion = request.Descripcion,
                TipoIncidenteId = request.TipoIncidenteId,
                NivelSeveridad = request.NivelSeveridad,
                FechaHoraInicio = DateTime.UtcNow,
                Estado = EstadoIncidente.Abierto
            };

            await _repository.AddAsync(incidente);
            return incidente.IncidenteId;
        }
    }
}
