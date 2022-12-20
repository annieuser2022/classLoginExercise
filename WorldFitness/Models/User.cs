using Microsoft.AspNetCore.Mvc;

namespace WorldFitness.Models
{
    public class User 
    {
        public string? Name { get; set; }
        public string? EmailId { get; set; }
        public string? Password { get; set; }
    }
}
