using University_Explorer_Portal___76239.Models;
using System.Net.Http.Json;

namespace University_Explorer_Portal___76239.Services
{
    public class StudentApplicationService
    {
        private readonly HttpClient _httpClient;

        private const string ApiUrl =
            "https://edutots.net/api/studentapplication";

        public StudentApplicationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // GET: Retrieve all student applications
        public async Task<List<StudentApplication>> GetApplicationsAsync()
        {
            var applications = await _httpClient
                .GetFromJsonAsync<List<StudentApplication>>(ApiUrl);

            return applications ?? new List<StudentApplication>();
        }


        // GET: Retrieve one student application by ID
        public async Task<StudentApplication?> GetApplicationByIdAsync(int id)
        {
            var applications = await GetApplicationsAsync();

            return applications.FirstOrDefault(
                a => a.StudentApplicationId == id);
        }


        // POST: Create a new student application
        public async Task<bool> CreateApplicationAsync(
            StudentApplication application)
        {
            var response = await _httpClient
                .PostAsJsonAsync(ApiUrl, application);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }


            // Read the error message from the API
            string errorDetails = await response.Content
                .ReadAsStringAsync();

            throw new HttpRequestException(
                $"API Error: {(int)response.StatusCode} " +
                $"{response.ReasonPhrase}. Details: {errorDetails}");
        }


        // PUT: Update an existing application
        public async Task<bool> UpdateApplicationAsync(
            int id, StudentApplication application)
        {
            var response = await _httpClient
                .PutAsJsonAsync($"{ApiUrl}/{id}", application);

            return response.IsSuccessStatusCode;
        }
    }
}
