using Microsoft.AspNetCore.Identity;

namespace Planner.Models
{
    public class User : IdentityUser<Guid>
    {
       //public Guid Id { get; set; }
        //public string? UserName { get; set; }
        public bool IsAdmin { get; set; }
        public ICollection<UserTripModel>? Trips { get; set; }
    }
}
