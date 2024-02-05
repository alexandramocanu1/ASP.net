namespace Planner.Models
{
    public class UserTripModel
    {
        public Guid UserId { get; set; }
        public int TripId { get; set; }
        public User User { get; set; }
        public TripModel Trip { get; set; }
    }
}
