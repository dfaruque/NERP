

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "HR/Employee", typeof(NERP.HR.Pages.EmployeeController))]

namespace NERP.HR.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("HR/Employee"), Route("{action=index}")]
    public class EmployeeController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/HR/Employee/EmployeeIndex.cshtml");
        }
    }
}