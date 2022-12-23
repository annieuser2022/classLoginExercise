using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WorldFitness.Models;

namespace WorldFitness.Controllers
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
        public IActionResult Login()
        {
            return View("LoginPage");
        }
        public IActionResult Logout()
        {
            CurrentUser.Name = "";
            CurrentUser.EmailId = "";
            CurrentUser.Role = "";
            return View("LogoutPage");
        }
        public IActionResult AddUser(User UserDetails)
        {

            UserData.UserList.Add(UserDetails);

            return RedirectToAction("ShowUsers","Admin");
        }

        public IActionResult DeleteUser(User UserDetails)
        {
            foreach(var eachUser in UserData.UserList.ToList())
            {
                if (eachUser.EmailId == UserDetails.EmailId)
                {
                    UserData.UserList.Remove(eachUser);

                    return RedirectToAction("ShowUsers", "Admin");
                }
            }
            return RedirectToAction("ShowUsers", "Admin", new { error = "User " + UserDetails.EmailId+" not found! Please try again..." });
        }

        public IActionResult CheckCredentials(Login details) 
        {
            foreach (var eachUser in UserData.UserList.ToList())
            {
                if (eachUser.EmailId == details.EmailId && eachUser.Password == details.Password)
                {
                    CurrentUser.EmailId= eachUser.EmailId;
                    CurrentUser.Name = eachUser.Name;
                    CurrentUser.Role = eachUser.Role;
                    if (eachUser.Role == "Admin")
                    {
                        return RedirectToAction("AdminIndex", "Admin", new { name = eachUser.Name });
                    }
                    else
                    {
                        return RedirectToAction("CustomerIndex", "Customer", new { name = eachUser.Name });
                    }
                }
            }

            ViewBag.errorMessage = "Invalid Login id or password. Try again...";

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