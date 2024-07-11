using Microsoft.AspNetCore.Identity;

namespace MovieStoreMVC.Models.Domain
{
    public class ApplicationUser: IdentityUser
    {
        public String Name { get; set; }
    }
}
