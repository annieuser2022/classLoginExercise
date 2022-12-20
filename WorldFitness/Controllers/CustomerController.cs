using Microsoft.AspNetCore.Mvc;

namespace WorldFitness.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CustomerIndex()
        {
            return View();
        }
    }
}
