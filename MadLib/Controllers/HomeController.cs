using Microsoft.AspNetCore.Mvc;
using MadLib.Models;
namespace MadLib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Welcome() { return View(); }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/horror")]
    public ActionResult Horror() { return View(); }

    [Route("/underwater")]
    public ActionResult UnderWater() { return View(); }

    [Route("/madlib")]                    
    public ActionResult MadLib(string name1, string name2, string animal, string exclamation, string verb, string noun)
    {
      Inputs myInputs = new Inputs();
      myInputs.Name1 = name1;
      myInputs.Name2 = name2;
      myInputs.Animal = animal;              
      myInputs.Exclamation = exclamation;
      myInputs.Verb = verb;
      myInputs.Noun = noun;
      return View(myInputs);
    } 
     [Route("/madlib2")]                    
    public ActionResult MadLib2(string name1, string name2, string animal, string exclamation, string verb, string noun)
    {
      Inputs myInputs = new Inputs();
      myInputs.Name1 = name1;
      myInputs.Name2 = name2;
      myInputs.Animal = animal;              
      myInputs.Exclamation = exclamation;
      myInputs.Verb = verb;
      myInputs.Noun = noun;
      return View(myInputs);
    } 
     [Route("/madlib3")]                    
    public ActionResult MadLib3(string name1, string name2, string animal, string exclamation, string verb, string noun)
    {
      Inputs myInputs = new Inputs();
      myInputs.Name1 = name1;
      myInputs.Name2 = name2;
      myInputs.Animal = animal;              
      myInputs.Exclamation = exclamation;
      myInputs.Verb = verb;
      myInputs.Noun = noun;
      return View(myInputs);
    } 
  }




}