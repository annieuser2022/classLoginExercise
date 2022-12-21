using Microsoft.AspNetCore.Mvc;

namespace WorldFitness.Models
{
    public class User 
    {

        public User(string name, string email, string password, string role)
        {
            this.Name = name;
            this.Password = password;
            this.EmailId = email;
            this.Role = role;
        }

        public string? Name { get; set; }
        public string? EmailId { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
    }
}
