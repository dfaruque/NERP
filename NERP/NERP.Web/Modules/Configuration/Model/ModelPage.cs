

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Configuration/Model", typeof(NERP.Configuration.Pages.ModelController))]

namespace NERP.Configuration.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Configuration/Model"), Route("{action=index}")]
    public class ModelController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Configuration/Model/ModelIndex.cshtml");
        }
    }
}