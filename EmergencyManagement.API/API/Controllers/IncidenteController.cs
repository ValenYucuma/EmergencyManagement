using EmergencyManagement.API.Application.Commands;
using EmergencyManagement.API.Core.Entities;
using EmergencyManagement.API.Core.Interfaces;
using EmergencyManagement.API.Infrastructure.Persistence;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace EmergencyManagement.API.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncidenteController : ControllerBase
    {
        private readonly AppDbContext _context;

        public IncidenteController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetIncidentes()
        {
            var incidentes = await _context.Incidentes.ToListAsync();
            return Ok(incidentes);
        }

        [HttpPost]
        public async Task<IActionResult> CreateIncidente(Incidente incidente)
        {
            _context.Incidentes.Add(incidente);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetIncidentes), new { id = incidente.IncidenteId }, incidente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateIncidente(Guid id, Incidente incidente)
        {
            if (id != incidente.IncidenteId)
            {
                return BadRequest();
            }

            _context.Entry(incidente).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIncidente(int id)
        {
            var incidente = await _context.Incidentes.FindAsync(id);
            if (incidente == null)
            {
                return NotFound();
            }

            _context.Incidentes.Remove(incidente);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }

}
