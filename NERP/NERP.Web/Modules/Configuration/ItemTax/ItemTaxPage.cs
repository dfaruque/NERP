

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Configuration/ItemTax", typeof(NERP.Configuration.Pages.ItemTaxController))]

namespace NERP.Configuration.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Configuration/ItemTax"), Route("{action=index}")]
    public class ItemTaxController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Configuration/ItemTax/ItemTaxIndex.cshtml");
        }
    }
}