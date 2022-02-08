using HotelListing.Configurations.Entites;
using HotelListing.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext: IdentityDbContext<ApiUser>
    {
        public DatabaseContext(DbContextOptions options): base(options) {}

        public DbSet<Country> Countries { get; set; }   
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RoleConfiguration ());
            modelBuilder.ApplyConfiguration(new CountryConfiguration ());
            modelBuilder.ApplyConfiguration(new HotelConfiguration ());


            //    modelBuilder.Entity<Hotel>().HasData(
            //        new Hotel
            //        {
            //            Id = 1,
            //            Name = "Sandals Resort and Spa",
            //            Address = "Negril",
            //            Rating = 4.5,
            //            CountryId = 1
            //        },
            //        new Hotel
            //        {
            //            Id = 2,
            //            Name = "Grand Palladium",
            //            Address = "Nassua",
            //            Rating = 4,
            //            CountryId = 2,
            //        },
            //        new Hotel
            //        {
            //            Id = 3,
            //            Name = "Comfort Suites",
            //            Address = "George Town",
            //            Rating = 4.5,
            //            CountryId = 3,
            //        });
        }
    }
}
