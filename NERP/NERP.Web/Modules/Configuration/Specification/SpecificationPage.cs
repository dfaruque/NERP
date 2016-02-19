

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Configuration/Specification", typeof(NERP.Configuration.Pages.SpecificationController))]

namespace NERP.Configuration.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Configuration/Specification"), Route("{action=index}")]
    public class SpecificationController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Configuration/Specification/SpecificationIndex.cshtml");
        }
    }
}