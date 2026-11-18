using University_Explorer_Portal___76239.Models;
using System.Net.Http.Json;

namespace University_Explorer_Portal___76239.Services
{
    public class CountryService
    {
        private readonly HttpClient _httpClient;

        public CountryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Country>> GetCountriesAsync()
        {
            var countries = await _httpClient.GetFromJsonAsync<List<Country>>(
                "https://countries.dev/countries");

            return countries ?? new List<Country>();
        }
    }
}
