
namespace NERP.Membership
{
    using Serenity.Services; using NERP.Common;
    using System;

    public class ResetPasswordEmailModel
    {
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string ResetLink { get; set; }
    }
}