

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Accounting/COA", typeof(NERP.Accounting.Pages.COAController))]

namespace NERP.Accounting.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Accounting/COA"), Route("{action=index}")]
    public class COAController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Accounting/COA/COAIndex.cshtml");
        }
    }
}