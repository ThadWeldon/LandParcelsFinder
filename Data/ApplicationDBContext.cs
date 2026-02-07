using Microsoft.EntityFrameworkCore;
using LandParcelFinder.Models;

namespace LandParcelFinder.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }

        public DbSet<Parcel> Parcels{ get; set;}
    }
}

