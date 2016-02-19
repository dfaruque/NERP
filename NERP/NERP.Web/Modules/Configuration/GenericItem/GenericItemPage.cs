

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Configuration/GenericItem", typeof(NERP.Configuration.Pages.GenericItemController))]

namespace NERP.Configuration.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Configuration/GenericItem"), Route("{action=index}")]
    public class GenericItemController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Configuration/GenericItem/GenericItemIndex.cshtml");
        }
    }
}