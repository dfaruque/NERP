

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Configuration/Currency", typeof(NERP.Configuration.Pages.CurrencyController))]

namespace NERP.Configuration.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Configuration/Currency"), Route("{action=index}")]
    public class CurrencyController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Configuration/Currency/CurrencyIndex.cshtml");
        }
    }
}