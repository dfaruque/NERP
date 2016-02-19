

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Configuration/Uom", typeof(NERP.Configuration.Pages.UomController))]

namespace NERP.Configuration.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Configuration/Uom"), Route("{action=index}")]
    public class UomController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Configuration/Uom/UomIndex.cshtml");
        }
    }
}