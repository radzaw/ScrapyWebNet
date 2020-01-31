using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScrapyWebNet.Models.API
{
    public class ApiListProjectsResponse
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("projects")]
        public List<string> Projects { get; set; }
    }
}
