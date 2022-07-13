using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index() { return View(); }
    // example route below:
    // [Route("/")]
    // public string Letter() { return "Our virtual postcard will go here soon!"; }

  }
}