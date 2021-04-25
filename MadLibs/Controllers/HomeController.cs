using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/Results")]
    public ActionResult Results(string Noun, string YourName, string Adjective, string Verb)
    {
      WordVariable newLibs = new WordVariable();
      newLibs.Noun = Noun; 
      newLibs.YourName = YourName;
      newLibs.Adjective = Adjective;
      newLibs.Verb = Verb;
      return View(newLibs);
    }
  }
}