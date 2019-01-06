using System.Web.Mvc;
using Rod.Services.Bl;

namespace Rod.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Page = "1";

            var newsService = new PostsService();
            var model = newsService.GetLatestPosts();
            return View(model);
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