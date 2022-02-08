using HotelListing.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entites
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
        }
    }
}
