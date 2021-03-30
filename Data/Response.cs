
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlazorApp.Data
{
    public class Response
    {
        [JsonPropertyNameAttribute("page")]
        public int Page { get; set; }

        [JsonPropertyNameAttribute("per_page")]
        public int PerPage { get; set; }

        [JsonPropertyNameAttribute("total")]
        public int Total { get; set; }

        [JsonPropertyNameAttribute("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyNameAttribute("data")]
        public List<User> Users { get; set; }
    }
}