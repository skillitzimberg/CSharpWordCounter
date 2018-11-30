using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {
        [Route("/index")]
        public ActionResult Index()
        {
          return View();
        }

    }
}
