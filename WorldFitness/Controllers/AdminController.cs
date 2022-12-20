using Microsoft.AspNetCore.Mvc;

namespace WorldFitness.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminIndex()
        {
            return View();
        }
        public IActionResult CreateUser()
        {
            return View();
        }
    }
}
