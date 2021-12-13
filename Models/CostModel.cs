using System.ComponentModel.DataAnnotations;

namespace C9_CostManager.Models
{
    public class CostModel
    {
        [Key]
        public int CostId { get; set; }

        [MaxLength(100)]

        public string Description { get; set; }

        public decimal CostAmount { get; set; }

        //Determines who paid
        public int OwnerId { get; set; }

        public ICollection<TripMemberModel> TripMembers { get; set; }





    }
}
