using System.ComponentModel.DataAnnotations;

namespace Movies_Rental.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
        [Display(Name = "Is Rented")]
        public bool IsRented { get; set; }
    }
}
