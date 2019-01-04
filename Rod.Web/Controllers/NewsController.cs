using System.Web.Mvc;

namespace Rod.Web.Controllers
{
    public class NewsController : Controller
    {
        public NewsController()
        {
            ViewBag.Page = "2";
        }

        public ActionResult All()
        {
            return View();
        }
    }
}