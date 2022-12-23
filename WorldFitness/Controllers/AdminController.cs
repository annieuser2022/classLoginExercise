using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
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
        
        public IActionResult DeleteUser()
        {
            return View();
        }        
        
        public IActionResult ShowUsers([Optional]string error)
        {
            ViewBag.Error = error;
            ViewBag.UsersList = UserData.UserList;
            return View();
        }
    }
}
