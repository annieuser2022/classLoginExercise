using Microsoft.AspNetCore.Mvc;

namespace WorldFitness.Models
{
    public class CurrentUser
    {
        public static string? Name { get; set; }
        public static string? EmailId { get; set; }
        public static string? Role { get; set; }
    }
}
