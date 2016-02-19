
namespace NERP.Membership
{
    using Serenity.Services; using NERP.Common;
    using System;

    public class ForgotPasswordRequest : ServiceRequest
    {
        public String Email { get; set; }
    }
}