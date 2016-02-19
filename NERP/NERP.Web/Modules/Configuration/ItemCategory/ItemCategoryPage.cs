

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Configuration/ItemCategory", typeof(NERP.Configuration.Pages.ItemCategoryController))]

namespace NERP.Configuration.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Configuration/ItemCategory"), Route("{action=index}")]
    public class ItemCategoryController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Configuration/ItemCategory/ItemCategoryIndex.cshtml");
        }
    }
}