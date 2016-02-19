

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Configuration/PaymentMethod", typeof(NERP.Configuration.Pages.PaymentMethodController))]

namespace NERP.Configuration.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Configuration/PaymentMethod"), Route("{action=index}")]
    public class PaymentMethodController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Configuration/PaymentMethod/PaymentMethodIndex.cshtml");
        }
    }
}