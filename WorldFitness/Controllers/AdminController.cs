using Microsoft.AspNetCore.Mvc;
using WorldFitness.Models;

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
        public IActionResult ShowUsers()
        {
            ViewBag.UsersList = UserData.UserList;
            return View();
        }
    }
}
