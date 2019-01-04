using System.Web.Mvc;

namespace Rod.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Page = "1";
            return View();
        }

        public ActionResult Managements()
        {
            ViewBag.Page = "3";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Page = "5";
            return View();
        }
    }
}