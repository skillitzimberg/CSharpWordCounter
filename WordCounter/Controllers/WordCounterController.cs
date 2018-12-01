using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/wordcounter")]
    public ActionResult Index()
    {
      return View();
    }

    // [HttpGet("/wordcounter/new")]
    // public ActionResult New()
    // {
    //   return View();
    // }
    //
    // [HttpPost("/wordcounter/show")]
    // public ActionResult Show(string wordToFind, string phraseToSearch)
    // {
    //   Counter newCounter = new Counter(wordToFind, phraseToSearch);
    //   newCounter.CountHowManyTimesTheWordWasFound();
    //   return View(newCounter);
    // }

  }
}
