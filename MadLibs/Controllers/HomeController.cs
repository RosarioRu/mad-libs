using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index() { return View(); }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/vacation")]
    public ActionResult Vacation(string place, string name, string verb, int years)
    {
      VacationStory userStory = new VacationStory();
      userStory.Place = place;
      userStory.Name = name;
      userStory.Verb = verb;
      userStory.Years = years;
      return View(userStory);
    }
    
    [Route("/form2")]
    public ActionResult Form2() {return View(); }

    [Route("/scary")]
    public ActionResult Scary(string place, string name, string verb)
    {
      VacationStory userStory = new VacationStory();
      userStory.Place = place;
      userStory.Name = name;
      userStory.Verb = verb;
      return View(userStory);
    }

    // example route below:
    // [Route("/")]
    // public string Letter() { return "Our virtual postcard will go here soon!"; }

  }
}