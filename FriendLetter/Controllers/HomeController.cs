using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    //Route decorator: Provides additional information to a route we define. The syntax looks like this: 
    
    [Route("/hello")]//this
    public string Hello() { return "hey pal!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "cya never"; }

    //Root path: The home page for our site. We can use a route decorator to specify a home page:
    [Route("/")] //root path for home page
    public ActionResult Letter() { 
      //ACTIONRESULT
      // the Letter Method is now an ActionResult
      //ActionResult : is a built-in MVC class that handles rendering views.
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      return View(myLetterVariable);
      //VIEW
      //The method Letter returns a method called View
      //View is a built-in method from the Microsoft.AspNetCore.Mvc namespace. When our route is invoked, it will return a view.
      
    }
    [Route("/form")]
    public ActionResult Form() { return View(); }
    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      return View(myLetterVariable);
    }  
  }
}
//VIEW cont.
//Views will always reside in the Views directory 
//View looks for -> directory view -> subdirectory that matches the controller name - in this case, Views -> Home -> Letter.cshtml
//the view method only cares about the method that invokes it - the method Letter^