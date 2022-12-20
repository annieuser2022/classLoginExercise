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

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoginPage()
        {
            return View();
        }
        public IActionResult CheckCredentials(Login details) 
        { 
            if(details.EmailId == adminId && details.Password == adminPassword)
            {
                return RedirectToAction("AdminIndex", "Admin");
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