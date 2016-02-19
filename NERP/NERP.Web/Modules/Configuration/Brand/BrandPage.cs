

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Configuration/Brand", typeof(NERP.Configuration.Pages.BrandController))]

namespace NERP.Configuration.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Configuration/Brand"), Route("{action=index}")]
    public class BrandController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Configuration/Brand/BrandIndex.cshtml");
        }
    }
}