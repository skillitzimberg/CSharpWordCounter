using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/index")]
        public ActionResult Index() { return View(); }

    }
}
