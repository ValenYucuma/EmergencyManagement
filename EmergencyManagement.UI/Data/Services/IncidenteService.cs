using EmergencyManagement.Shared;
using System.Net.Http.Json;

namespace EmergencyManagement.UI.Data.Services
{
    public class IncidenteService
    {
        private readonly HttpClient _httpClient;

        public IncidenteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<IncidenteDTO>> ObtenerIncidentesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<IncidenteDTO>>("api/incidentes");
        }

        public async Task CrearIncidenteAsync(IncidenteDTO incidente)
        {
            await _httpClient.PostAsJsonAsync("api/incidentes", incidente);
        }
    }

}
