using System.ComponentModel.DataAnnotations;

namespace Movies_Rental.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
