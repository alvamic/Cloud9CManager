using C9_CostManager.Models;

namespace C9_CostManager.Services
{
    public interface ITripRepository
    {
        //Read
        TripModel GetTripModel(int id);
        //Create
        void AddTrip(TripModel t);

        //Update
        TripModel UpdateTrip(TripModel tripModelChanges);
        //Delete
        TripModel DeleteTripModel(int id);

        IEnumerable<TripModel> GetAllTripModels();


        void GenerateTripPasscode();

        int GetTripPassCode(int id);



    }
}
