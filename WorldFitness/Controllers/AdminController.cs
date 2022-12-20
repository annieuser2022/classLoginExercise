using Microsoft.AspNetCore.Mvc;

namespace WorldFitness.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View("AdminIndex");
        }
    }
}
