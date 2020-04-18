using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesAPIWebApp.Models;

namespace MoviesAPIWebApp.Data
{
    public class MoviesAPIWebAppDbContext : DbContext
    {
        public MoviesAPIWebAppDbContext (DbContextOptions<MoviesAPIWebAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesAPIWebApp.Models.Movie> Movie { get; set; }
    }
}
