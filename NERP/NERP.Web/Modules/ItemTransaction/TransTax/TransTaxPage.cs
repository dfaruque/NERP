

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "ItemTransaction/TransTax", typeof(NERP.ItemTransaction.Pages.TransTaxController))]

namespace NERP.ItemTransaction.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("ItemTransaction/TransTax"), Route("{action=index}")]
    public class TransTaxController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/ItemTransaction/TransTax/TransTaxIndex.cshtml");
        }
    }
}