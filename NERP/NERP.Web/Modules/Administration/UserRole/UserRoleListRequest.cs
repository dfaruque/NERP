﻿
namespace NERP.Administration
{
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.Services; using NERP.Common;
    using Serenity.Web;
    using System.Web.Mvc;

    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}