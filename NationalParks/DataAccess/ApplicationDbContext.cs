using Microsoft.EntityFrameworkCore;
using NationalParks.Models;

namespace NationalParks.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Park> Parks { get; set; }
        public DbSet<Datum> RootObject { get; set; }
        public DbSet<Amenities> Amenity { get; set; }
        public DbSet<Accessibility> Accessibilityy { get; set; }
        public DbSet<Campsites> Campsite {get; set;}
        
    }
}
