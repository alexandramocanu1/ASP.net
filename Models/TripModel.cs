namespace Planner.Models
{
    public class TripModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int UserId { get; set; }
        public DateTime TravelDate { get; set; }
        public int TravelDuration { get; set; }
        public string? Accommodation { get; set; }
        public bool LikedAccommodation { get; set; }
        public ICollection<UserTripModel>? Trips { get; set; }


        public decimal CalculateTotalCost()
        {
            return TravelDuration * 100;
        }
    }
}
