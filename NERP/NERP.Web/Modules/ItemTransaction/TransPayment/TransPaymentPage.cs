

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "ItemTransaction/TransPayment", typeof(NERP.ItemTransaction.Pages.TransPaymentController))]

namespace NERP.ItemTransaction.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("ItemTransaction/TransPayment"), Route("{action=index}")]
    public class TransPaymentController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/ItemTransaction/TransPayment/TransPaymentIndex.cshtml");
        }
    }
}