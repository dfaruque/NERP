

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Configuration/Organogram", typeof(NERP.Configuration.Pages.OrganogramController))]

namespace NERP.Configuration.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Configuration/Organogram"), Route("{action=index}")]
    public class OrganogramController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Configuration/Organogram/OrganogramIndex.cshtml");
        }
    }
}