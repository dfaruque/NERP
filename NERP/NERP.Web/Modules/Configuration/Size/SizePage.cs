

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Configuration/Size", typeof(NERP.Configuration.Pages.SizeController))]

namespace NERP.Configuration.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Configuration/Size"), Route("{action=index}")]
    public class SizeController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Configuration/Size/SizeIndex.cshtml");
        }
    }
}