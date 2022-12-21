using Microsoft.AspNetCore.Mvc;

namespace WorldFitness.Models
{
    public class UserData : Controller
    {
        public static List<User>? userList = new List<User>()
        {
            new User("Kate", "kate@gmail.com", "123", "admin"),
            new User("Paul", "paul@gmail.com", "123", "customer"),
        };

    }
}
