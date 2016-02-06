using System.Web.Mvc;

namespace OfficeAdmin.Web.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            // if no login cookie, else return to main view
            return View();
        }
    }
}