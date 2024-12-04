using EmergencyManagement.Model.DTOs;
using System.Net.Http.Json;

namespace EmergencyManagement.Services
{
    public class IncidentApiService
    {
        private readonly HttpClient _httpClient;

        public IncidentApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<IncidentDto>> GetAllIncidentsAsync() =>
            await _httpClient.GetFromJsonAsync<IEnumerable<IncidentDto>>("api/incident");
    }

}
