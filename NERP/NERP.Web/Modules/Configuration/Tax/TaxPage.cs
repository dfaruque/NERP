

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Configuration/Tax", typeof(NERP.Configuration.Pages.TaxController))]

namespace NERP.Configuration.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Configuration/Tax"), Route("{action=index}")]
    public class TaxController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Configuration/Tax/TaxIndex.cshtml");
        }
    }
}