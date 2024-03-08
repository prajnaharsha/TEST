
using Newtonsoft.Json;

namespace LitHold.Data
{
    /// <summary>
    /// Represents a data transfer object (DTO) for the LITHOLD execution details
    /// </summary>
    public class LitholdExecutionDetailsDto
    {
        [JsonProperty("Matter ID")]
        public string MatterID { get; set; } = string.Empty;

        [JsonProperty("Matter Description")]
        public string MatterDesc { get; set; } = string.Empty;

        [JsonProperty("Document Count")]
        public int? DocumentCount { get; set; }
        [JsonProperty("Processed Document Count")]
        public int? ProcessedDocumentCount { get; set; }
        [JsonProperty("Duration of LitHold execution")]
        public string ExecutionDuration { get; set; } = string.Empty;

    }
}
