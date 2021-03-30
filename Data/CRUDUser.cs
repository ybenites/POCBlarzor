using System;
using System.Text.Json.Serialization;

namespace BlazorApp.Data
{
    public class CRUDUser
    {
        [JsonPropertyNameAttribute("id"), JsonNumberHandlingAttribute(JsonNumberHandling.AllowReadingFromString)]
        public int Id { get; set; }

        [JsonPropertyNameAttribute("name")]
        public string Name { get; set; }

        [JsonPropertyNameAttribute("job")]
        public string Job { get; set; }

        [JsonPropertyNameAttribute("createdAt")]
        public DateTime CreatedTimestamp { get; set; }

        [JsonPropertyNameAttribute("updatedAt")]
        public DateTime UpdatedTimestamp { get; set; }
    }
}