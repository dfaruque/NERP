

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Configuration/Style", typeof(NERP.Configuration.Pages.StyleController))]

namespace NERP.Configuration.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Configuration/Style"), Route("{action=index}")]
    public class StyleController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Configuration/Style/StyleIndex.cshtml");
        }
    }
}