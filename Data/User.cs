using System;
using System.Text.Json.Serialization;

namespace BlazorApp.Data
{
    public class User
    {
        [JsonPropertyNameAttribute("id")]
        public int Id { get; set; }
        
        [JsonPropertyNameAttribute("email")]
        public string Email { get; set; }

        [JsonPropertyNameAttribute("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyNameAttribute("last_name")]
        public string LastName { get; set; }

        [JsonPropertyNameAttribute("avatar")]
        public string AvatarURI { get; set; }
    }
}