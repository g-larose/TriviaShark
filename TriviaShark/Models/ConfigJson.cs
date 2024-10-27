using System.Text.Json.Serialization;

namespace TriviaShark.Models
{
    public class ConfigJson
    {
        [JsonPropertyName("connectionstring")]
        public string? ConnectionString { get; set; }

    }
}
