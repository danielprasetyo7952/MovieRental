using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movies_Rental.Models;

namespace Movies_Rental.Data
{
    public class Movies_RentalContext : DbContext
    {
        public Movies_RentalContext (DbContextOptions<Movies_RentalContext> options)
            : base(options)
        {
        }

        public DbSet<Movies_Rental.Models.Movie> Movie { get; set; } = default!;

        public DbSet<Movies_Rental.Models.User> User { get; set; } = default!;
    }
}
