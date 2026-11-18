using System.Text.Json.Serialization;

namespace University_Explorer_Portal___76239.Models
{
    public class Country
    {
        public string Name { get; set; } = string.Empty;

        // Some countries or territories have no capital
        public string? Capital { get; set; }

        public string? Region { get; set; }

        public long Population { get; set; }

        // Country flag emoji
        [JsonPropertyName("flag")]
        public string? FlagEmoji { get; set; }

        // Country flag image
        public CountryFlags? Flags { get; set; }
    }

    public class CountryFlags
    {
        public string? Png { get; set; }

        public string? Svg { get; set; }
    }
}
