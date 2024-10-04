using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        public string Index()
        {
            return "Hello World !!!";
        }

        //
        // GET: /HelloWorld/Welcome
        public ViewResult Welcome()
        {
            ViewBag.Title = "Welcome from Hello World";
            return View();
        }
    }
}
