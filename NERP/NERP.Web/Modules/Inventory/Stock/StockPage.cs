

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Inventory/Stock", typeof(NERP.Inventory.Pages.StockController))]

namespace NERP.Inventory.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Inventory/Stock"), Route("{action=index}")]
    public class StockController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Inventory/Stock/StockIndex.cshtml");
        }
    }
}