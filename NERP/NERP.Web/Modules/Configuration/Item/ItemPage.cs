

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Configuration/Item", typeof(NERP.Configuration.Pages.ItemController))]

namespace NERP.Configuration.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Configuration/Item"), Route("{action=index}")]
    public class ItemController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Configuration/Item/ItemIndex.cshtml");
        }
    }
}