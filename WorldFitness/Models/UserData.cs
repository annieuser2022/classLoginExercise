using Microsoft.AspNetCore.Mvc;

namespace WorldFitness.Models
{
    public class UserData
    {
        public static List<User>? UserList = new List<User>()
        {
            new User("Kate", "kate@gmail.com", "123", "Admin"),
            new User("Paul", "paul@gmail.com", "123", "Customer"),
        };
    }
}
