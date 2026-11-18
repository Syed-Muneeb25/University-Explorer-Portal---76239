using University_Explorer_Portal___76239.Models;
using System.Net.Http.Json;

namespace University_Explorer_Portal___76239.Services
{
    public class UniversityService
    {
        private readonly HttpClient _httpClient;

        public UniversityService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<University>> GetUniversitiesAsync(string country)
        {
            string url = "http://universities.hipolabs.com/search?country="
                + Uri.EscapeDataString(country);

            var universities = await _httpClient
                .GetFromJsonAsync<List<University>>(url);

            return universities ?? new List<University>();
        }
    }
}
