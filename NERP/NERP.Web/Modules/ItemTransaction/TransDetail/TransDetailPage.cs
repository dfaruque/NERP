

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "ItemTransaction/TransDetail", typeof(NERP.ItemTransaction.Pages.TransDetailController))]

namespace NERP.ItemTransaction.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("ItemTransaction/TransDetail"), Route("{action=index}")]
    public class TransDetailController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/ItemTransaction/TransDetail/TransDetailIndex.cshtml");
        }
    }
}