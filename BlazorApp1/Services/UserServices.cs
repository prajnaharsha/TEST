namespace LitHold.Services
{
    /// <summary>
    /// Service for managing user-related operations.
    /// </summary>
    public class UserServices(IHttpContextAccessor httpContextAccessor) : IUserService
    {
        public IHttpContextAccessor HttpContextAccessor { get; } = httpContextAccessor;

        /// <summary>
        /// Gets the current Active Directory (AD) user name.
        /// </summary>
        /// <returns>The current AD user name.</returns>
        public string GetCurrentADUserName()
        {
            var currentADUser = HttpContextAccessor.HttpContext?.User?.Identity?.Name;
            string userName = string.Empty;
            if (currentADUser != null)
            {
                userName = currentADUser.Split("\\")[1];
            }
            return userName;
        }
    }
}
