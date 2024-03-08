namespace LitHold.Utility
{
    /// <summary>
    /// Provides extension methods for handling exceptions.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Retrieves error information from the specified exception and its inner exceptions.
        /// </summary>
        /// <param name="ex">The exception from which to retrieve error information.</param>
        /// <param name="isFirstLevel">Specifies whether this is the first level of exception.</param>
        /// <returns>Error information string.</returns>
        public static string GetErrorInfo(this Exception ex, bool isFirstLevel = true)
        {
            if (ex == null) return string.Empty;
            string errorInfo = ex.Message.Trim();
            if (ex.InnerException != null)
            {
                errorInfo += (errorInfo.EndsWith('.') ? " " : ". ") + (isFirstLevel ? "Additional Info : " : "") + ex.InnerException.GetErrorInfo(false);
            }
            return errorInfo;
        }
    }
}
