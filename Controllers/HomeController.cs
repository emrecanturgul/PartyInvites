using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Diagnostics;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // GET: /Home/Register
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(GuestResponse response)
        {
            Repository.AddResponse(response);
            return View("RegisterComplete", response);
        }

        public IActionResult ListResponses()
        {
            if (Repository.Responses().Any()) {
                return View(Repository.Responses());
            }
            return View("NoRegisteredResponses");
            
        }

        public IActionResult PeopleAttending()
        {
            var peopleAttending = 
                Repository.Responses().Where(r => r.WillAttend == true);
            return View("ListResponses", peopleAttending);
        }
        
        public string Contact()
        {
            return "Contact information is not currently available";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
