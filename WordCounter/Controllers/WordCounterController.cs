using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {
        [HttpGet("/index")]
        public ActionResult Index()
        {
          return View();
        }

    }
}
