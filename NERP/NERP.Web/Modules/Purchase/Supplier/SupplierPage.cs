

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Purchase/Supplier", typeof(NERP.Purchase.Pages.SupplierController))]

namespace NERP.Purchase.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Purchase/Supplier"), Route("{action=index}")]
    public class SupplierController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Purchase/Supplier/SupplierIndex.cshtml");
        }
    }
}