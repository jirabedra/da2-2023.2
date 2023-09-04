using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class MoviesContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

        public MoviesContext() { }

        public MoviesContext(DbContextOptions options) : base(options) { }
    }
}
