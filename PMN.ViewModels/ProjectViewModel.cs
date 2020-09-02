using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PMN.ViewModels
{
    public class ProjectViewModel
    {
        [JsonPropertyName("nidProject")]
        public int NidProject { get; set; }
        [JsonPropertyName("tidProject")]
        public string TidProject { get; set; }
        [JsonPropertyName("desProject")]
        public string DesProject { get; set; }
        [JsonPropertyName("datProjectStart")]
        public DateTime DatProjectStart { get; set; }
        [JsonPropertyName("datProjectEnd")]
        public DateTime? DatProjectEnd { get; set; }
    }
}
