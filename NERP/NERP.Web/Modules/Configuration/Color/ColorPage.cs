

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Configuration/Color", typeof(NERP.Configuration.Pages.ColorController))]

namespace NERP.Configuration.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Configuration/Color"), Route("{action=index}")]
    public class ColorController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Configuration/Color/ColorIndex.cshtml");
        }
    }
}