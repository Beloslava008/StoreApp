using Microsoft.AspNetCore.Identity;

namespace StoreApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }
    }
}
