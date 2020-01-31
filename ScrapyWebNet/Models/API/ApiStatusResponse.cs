using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScrapyWebNet.Models.API
{
    public class ApiStatusResponse
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("running")]
        public int Running { get; set; }

        [JsonPropertyName("pending")]
        public int Pending { get; set; }

        [JsonPropertyName("finished")]
        public int Finished { get; set; }

        [JsonPropertyName("node_name")]
        public string NodeName { get; set; }
    }
}
