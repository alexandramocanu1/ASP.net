using Microsoft.AspNetCore.Identity;

namespace Planner.Models
{
    public class ApplicationUser //: IdentityUser
    {
        public bool IsAdmin { get; set; }
    }
}
