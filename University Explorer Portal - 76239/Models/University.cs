using System.Text.Json.Serialization;

namespace University_Explorer_Portal___76239.Models
{
    public class University
    {
        public string Name { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        // A university may have multiple websites
        [JsonPropertyName("web_pages")]
        public List<string> WebPages { get; set; } = new();

        // A university may have multiple domains
        public List<string> Domains { get; set; } = new();
    }
}
