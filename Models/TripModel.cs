using System.ComponentModel.DataAnnotations;

namespace C9_CostManager.Models
{
    public class TripModel
    {
        [Key]
        public int TripId { get; set; }

        public string TripName { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool TripStatusComplete { get; set; } = false;

        public int TripPasscode { get; set; }

        public ICollection<TripMemberModel> TripMembers { get; set; }
    }
}
