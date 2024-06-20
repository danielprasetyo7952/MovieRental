﻿namespace Movies_Rental.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
        public bool IsRented { get; set; }
    }
}
