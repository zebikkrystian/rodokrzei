using System.Web.Mvc;
using Rod.Services.Bl;

namespace Rod.Web.Controllers
{
    public class NewsController : Controller
    {
        private readonly PostsService _service;

        public NewsController()
        {
            ViewBag.Page = "2";
            _service = new PostsService();
        }

        public ActionResult All()
        {
            var posts = _service.GetAll();
            return View(posts);
        }
    }
}