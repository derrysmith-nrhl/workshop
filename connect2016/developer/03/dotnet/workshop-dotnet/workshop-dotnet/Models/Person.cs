﻿using Newtonsoft.Json;

namespace workshop_dotnet.Models
{
    public class Person
    {
        [JsonProperty("document_id")]
        public string Id { get; set; }

        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("lastname")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}