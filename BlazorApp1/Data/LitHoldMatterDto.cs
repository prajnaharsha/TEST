
using LitHold.Utility;
using Newtonsoft.Json;

namespace LitHold.Data
{
    /// <summary>
    /// Represents a data transfer object (DTO) for the LIHOLD mattger
    /// </summary>
    public class LitHoldMatterDto
    {
        public string Matters { get; set; } = string.Empty;
        public string MatterID { get; set; } = string.Empty;
        [JsonProperty("Matter Description")]
        public string MatterDesc { get; set; } = string.Empty;
        public string ProfName { get; set; } = string.Empty;
        [JsonProperty("LitHold Execute Date")]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter), "MM/dd/yyyy")]
        public DateTime LitHoldExecuteDate { get; set; }
        [JsonProperty("LitHold Request Date")]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter), "MM/dd/yyyy")]
        public DateTime LitHoldRequestDate { get; set; }
        [JsonProperty("LitHold Start Date")]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter), "MM/dd/yyyy")]
        public DateTime LitHoldStartDate { get; set; }
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public DateTime? LitHoldEndDate { get; set; }

        [JsonProperty("LitHold End Date")]
        public string HoldEndDateText
        {
            get
            {
                if (LitHoldEndDate.HasValue)
                {
                    return LitHoldEndDate.Value.ToString("MM/dd/yyyy");
                }
                else
                {
                    return "No End Date";
                }
            }
        }
        public string PreserveFutureEvents { get; set; } = string.Empty;      

    }
}
