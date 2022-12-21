using Microsoft.AspNetCore.Mvc;

namespace WorldFitness.Models
{
    public class CurrentUser : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
