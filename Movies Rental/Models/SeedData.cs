using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Movies_Rental.Data;
using System;
using System.Linq;

namespace Movies_Rental.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Movies_RentalContext(
                serviceProvider.GetRequiredService<DbContextOptions<Movies_RentalContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        Genre = "Romantic",
                        Price = 50000.00M,
                        IsRented = false
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        Genre = "Comedy",
                        Price = 57000.00M,
                        IsRented = false
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        Genre = "Comedy",
                        Price = 30000.00M,
                        IsRented = false
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        Genre = "Western",
                        Price = 75000.00M,
                        IsRented = false
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
