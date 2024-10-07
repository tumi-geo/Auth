using Microsoft.AspNetCore.Identity;

namespace Auth.Models
{
    public class AppUser:IdentityUser
    {
        public string? FullName { get; set; }
    }

}