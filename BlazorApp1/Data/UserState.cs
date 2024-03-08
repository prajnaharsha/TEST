using Newtonsoft.Json;

namespace LitHold.Data
{
    /// <summary>
    /// Represents a data transfer object (DTO) for User State(User and application settings).
    /// </summary>
    public class UserState
    {
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public string UserName { get; set; } = string.Empty;
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public bool HasPermission { get; set; } = false;
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public string EmailAddress { get; set; } = string.Empty;
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public string ProfessionalsAtom { get; set; } = string.Empty;
        [JsonProperty("Show Snapshot Report Column")]
        public bool ShowSnapshotReportColumn { get; set; }
        [JsonProperty("Show Audit Report Column")]
        public bool ShowAuditReportColumn { get; set; }
        [JsonProperty("Matter Find Record Return Limit")]
        public int RecordReturnLimit { get; set; }
        [JsonProperty("LitHold Query Execution Timeout (In Seconds)")]
        public int LitholdTimeout { get; set; }
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public bool HoldProcessDialogOpen { get; set; }

        public event Action? UserStateChanged;
        public event Func<Task>? HoldProcessClosed;
        
        public void OnUserStateChanged()
        {
            UserStateChanged?.Invoke();
        }
        public void OnHoldProcessCompleted()
        {
            HoldProcessClosed?.Invoke();
        }
        
    }
}
