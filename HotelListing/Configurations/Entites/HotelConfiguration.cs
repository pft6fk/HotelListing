using HotelListing.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entites
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
               }
            );
        }
    }
}
