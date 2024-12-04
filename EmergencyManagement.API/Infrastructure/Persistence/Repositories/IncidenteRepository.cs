using EmergencyManagement.API.Core.Entities;
using EmergencyManagement.API.Core.Interfaces;
using Microsoft.EntityFrameworkCore;



namespace EmergencyManagement.API.Infrastructure.Persistence.Repositories
{
    // En IncidenteRepository.cs
    public class IncidenteRepository : IIncidenteRepository
    {
        private readonly AppDbContext _context;

        public IncidenteRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Incidente> GetByIdAsync(Guid id)
        {
            return await _context.Incidentes.FindAsync(id);
        }

        public async Task AddAsync(Incidente incidente)
        {
            await _context.Incidentes.AddAsync(incidente);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Incidente incidente)  // Implementación del método UpdateAsync
        {
            var existingIncidente = await _context.Incidentes.FindAsync(incidente.IncidenteId);
            if (existingIncidente != null)
            {
                existingIncidente.Titulo = incidente.Titulo;
                existingIncidente.Descripcion = incidente.Descripcion;
                existingIncidente.NivelSeveridad = incidente.NivelSeveridad;
                existingIncidente.Estado = incidente.Estado;
                existingIncidente.Ubicacion = incidente.Ubicacion;
                existingIncidente.FechaHoraInicio = incidente.FechaHoraInicio;
                existingIncidente.FechaHoraFin = incidente.FechaHoraFin;

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            var incidente = await _context.Incidentes.FindAsync(id);
            if (incidente != null)
            {
                _context.Incidentes.Remove(incidente);
                await _context.SaveChangesAsync();
            }
        }
    }

}
