using System.ComponentModel.DataAnnotations;

namespace C9_CostManager.Models
{
    public class TripMemberModel
    {
        [Key]
        public int TripMemberId { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }

        public string Name { get; set; }

        //Setting relationship to trip (one to many for now) 
        public int TripId { get; set; }

        public TripModel TripModel { get; set; }

        //Setting relationship to CostModel (collection navigation property will be set on both sides to create junction table) 

        public ICollection<CostModel> Costs { get; set; }


    }
}
