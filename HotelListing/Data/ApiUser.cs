using Microsoft.AspNetCore.Identity;

namespace HotelListing.Data
{
    public class ApiUser: IdentityUser
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
    }
}
