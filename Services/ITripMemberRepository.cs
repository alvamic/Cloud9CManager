using C9_CostManager.Models;

namespace C9_CostManager.Services
{
    public interface ITripMemberRepository
    {

        //Read
        TripMemberModel GetMember(int id);
        //Create
        void AddMember(TripMemberModel m);

        //Update
        TripMemberModel UpdateMember(TripMemberModel tripMemberChanges);
        //Delete
        TripMemberModel DeleteTripMember(int id);
    }
}
