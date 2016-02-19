

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Sales/Customer", typeof(NERP.Sales.Pages.CustomerController))]

namespace NERP.Sales.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Sales/Customer"), Route("{action=index}")]
    public class CustomerController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Sales/Customer/CustomerIndex.cshtml");
        }
    }
}