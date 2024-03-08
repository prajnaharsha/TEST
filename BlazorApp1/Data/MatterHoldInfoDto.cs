using Microsoft.AspNetCore.Components.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using LitHold.Utility;

namespace LitHold.Data
{
    /// <summary>
    /// Represents a data transfer object (DTO) for the matter selected for HOLD
    /// </summary>
    public class MatterHoldInfoDto
    {
        public string Matters { get; set; } = string.Empty;
        [JsonProperty("Matter ID")]
        public string MatterID { get; set; } = string.Empty;
        [JsonProperty("Matter Description")]
        public string MatterDesc { get; set; } = string.Empty;
        public string ClientSort { get; set; } = string.Empty;
        public string AreaOfLaw { get; set; } = string.Empty;
        [JsonProperty("Matter Type")]
        public string MatterType { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;

        [JsonProperty("Status Date")]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter), "MM/dd/yyyy")]
        public DateTime StatusDate { get; set; }
        [JsonProperty("Hold Request Date")]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter), "MM/dd/yyyy")]
        public DateTime HoldRequestDate { get; set; }

        [JsonProperty("Hold Start Date")]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter), "MM/dd/yyyy")]
        public DateTime HoldStartDate { get; set; }
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public DateTime? HoldEndDate { get; set; }
        [JsonProperty("Hold End Date")]
        public string HoldEndDateText
        {
            get
            {
                if (HoldEndDate.HasValue)
                {
                    return HoldEndDate.Value.ToString("MM/dd/yyyy");
                }
                else
                {
                    return "No End Date";
                }
            }
        }

        [JsonProperty("Preserve Future Events")]
        [Newtonsoft.Json.JsonConverter(typeof(CustomBooleanConverter))]
        public bool PreserveFutureEVents { get; set; }

        [JsonProperty("User")]
        public string Requestor { get; set; } = string.Empty;

        [JsonProperty("Request Form Name")]
        public string RequestFormName { get; set; } = string.Empty;
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public IBrowserFile? HoldRequestFile { get; set; }

        [Newtonsoft.Json.JsonIgnoreAttribute]
        public bool NoEndDate { get; set; }

    }


}
