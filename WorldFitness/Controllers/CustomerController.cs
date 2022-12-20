using Microsoft.AspNetCore.Mvc;

namespace WorldFitness.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CustomerIndex(string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }
}
