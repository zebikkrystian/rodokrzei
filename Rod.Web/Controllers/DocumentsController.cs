using System.Web.Mvc;

namespace Rod.Web.Controllers
{
    public class DocumentsController : Controller
    {
        public DocumentsController()
        {
            ViewBag.Page = "4";
        }

        public ActionResult All()
        {
            return View();
        }
    }
}