using EmergencyManagement.API.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmergencyManagement.API.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Incidente> Incidentes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
