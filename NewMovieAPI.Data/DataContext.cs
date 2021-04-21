namespace NewMovieAPI.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using NewMovieAPI.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        public IConfiguration Configuration { get; } // so ovoj moze da citame od app settings
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
