using EmergencyManagement.API.Core.Entities;

namespace EmergencyManagement.API.Core.Interfaces
{
    public interface IIncidenteRepository
    {
        Task<Incidente> GetByIdAsync(Guid id);
        Task AddAsync(Incidente incidente);
        Task UpdateAsync(Incidente incidente); 
        Task DeleteAsync(Guid id);
    }
}
