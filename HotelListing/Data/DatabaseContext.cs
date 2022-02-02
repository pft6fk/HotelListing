using HotelListing.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions options): base(options) {}

        public DbSet<Country> Countries { get; set; }   
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    CountryName = "Jamaica",
                    ShortName = "JM"

                },
                new Country
                {
                    Id = 2,
                    CountryName = "Bahamas",
                    ShortName = "BS"
                },
                new Country
                {
                    Id = 3,
                    CountryName = "Cayman Island",
                    ShortName = "CI"
                });
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    Rating = 4.5,
                    CountryId = 1
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Grand Palladium",
                    Address = "Nassua",
                    Rating = 4,
                    CountryId = 2,
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Comfort Suites",
                    Address = "George Town",
                    Rating = 4.5,
                    CountryId = 3,
                });
        }
    }
}
