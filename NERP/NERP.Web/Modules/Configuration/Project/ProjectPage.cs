

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Configuration/Project", typeof(NERP.Configuration.Pages.ProjectController))]

namespace NERP.Configuration.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Configuration/Project"), Route("{action=index}")]
    public class ProjectController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Configuration/Project/ProjectIndex.cshtml");
        }
    }
}