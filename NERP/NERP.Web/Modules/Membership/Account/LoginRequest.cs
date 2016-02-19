
namespace NERP.Membership
{
    using Serenity.Services; using NERP.Common;

    public class LoginRequest : ServiceRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}