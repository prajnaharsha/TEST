
namespace LitHold.Data
{
    /// <summary>
    /// Represents a data transfer object (DTO) for matters.
    /// </summary>
    public class MatterDto
    {
        public string Matters { get; set; } = string.Empty;
        public string MatterID { get; set; } = string.Empty;
        public string MatterDesc { get; set; } = string.Empty;
        public string ClientSort { get; set; } = string.Empty;
        public string AreaOfLaw { get; set; } = string.Empty;
        public string MatterType { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime StatusDate { get; set; }

    }
}
