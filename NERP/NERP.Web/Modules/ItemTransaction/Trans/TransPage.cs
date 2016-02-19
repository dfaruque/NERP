

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "ItemTransaction/Trans", typeof(NERP.ItemTransaction.Pages.TransController))]

namespace NERP.ItemTransaction.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("ItemTransaction/Trans"), Route("{action=index}")]
    public class TransController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/ItemTransaction/Trans/TransIndex.cshtml");
        }
    }
}