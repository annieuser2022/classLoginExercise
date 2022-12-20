using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WorldFitness.Models;

namespace WorldFitness.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        static string adminPassword="admin";
        static string adminId="admin@fitness.com";
        static string customerId="customer@fitness.com";
        static string customerPassword="customer";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View("LoginPage");
        }

        public IActionResult CheckCredentials(Login details) 
        { 
            if(details.EmailId == adminId && details.Password == adminPassword)
            {
                return RedirectToAction("AdminIndex", "Admin");
            }
            else if (details.EmailId == customerId && details.Password == customerPassword)
                {
                    return RedirectToAction("CustomerIndex", "Customer");
                }
            return View("LoginPage"); 
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}