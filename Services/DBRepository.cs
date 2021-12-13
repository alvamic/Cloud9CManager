using C9_CostManager.Models;
using C9_CostManager.Data;

namespace C9_CostManager.Services
{
    public class DBRepository : ITripRepository, ITripMemberRepository, ICostRepository
    {
        //TODO: Add business logic for implemented interfaces


        //use dependency injection to access the DB through the application context
        private ApplicationDbContext _applicationDbContext;

        public DBRepository(ApplicationDbContext context)
        {
            _applicationDbContext = context;
        }



        //-----------------------------------------------Trip Model Logic-----------------------------------------------//
        public void AddTrip(TripModel t)
        {
            //t.TripId = _applicationDbContext.Trips.Max(e => e.TripId) + 1;
            _applicationDbContext.Trips.Add(t);
            _applicationDbContext.SaveChanges();

        }

        public TripModel DeleteTripModel(int id)
        {
            TripModel trip = _applicationDbContext.Trips.FirstOrDefault(e => e.TripId == id);
            if (trip != null)
            {
                _applicationDbContext.Trips.Remove(trip);
            }

            _applicationDbContext.SaveChanges();
            return trip;
        }

        public void GenerateTripPasscode()
        {
            throw new NotImplementedException();
        }

        public int GetTripPassCode(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TripModel> GetAllTripModels()
        {
            return _applicationDbContext.Trips.ToList();
        }

        public TripModel GetTripModel(int id)
        {
            return _applicationDbContext.Trips.FirstOrDefault(e => e.TripId == id);
        }

        public TripModel UpdateTrip(TripModel tripModelChanges)
        {
            var trip = _applicationDbContext.Trips.FirstOrDefault(e => e.TripId == tripModelChanges.TripId);
            if (trip != null)
            {
                trip.TripName = tripModelChanges.TripName;
                trip.StartDate = tripModelChanges.StartDate;
                trip.EndDate = tripModelChanges.EndDate;
                trip.TripStatusComplete = tripModelChanges.TripStatusComplete;
                trip.TripMembers = tripModelChanges.TripMembers;

            }

            _applicationDbContext.SaveChanges();
            return trip;
        }

        //-----------------------------------------------Trip Member Model Logic-----------------------------------------------//
        public void AddMember(TripMemberModel m)
        {
            throw new NotImplementedException();
        }

        public TripMemberModel UpdateMember(TripMemberModel tripMemberChanges)
        {
            throw new NotImplementedException();
        }

        public TripMemberModel GetMember(int id)
        {
            throw new NotImplementedException();
        }

        public TripMemberModel DeleteTripMember(int id)
        {
            throw new NotImplementedException();
        }


        //-----------------------------------------------Cost Model Logic-----------------------------------------------//

        public CostModel GetCost(int id)
        {
            throw new NotImplementedException();
        }

        public void AddCost(CostModel c)
        {
            throw new NotImplementedException();
        }

        public CostModel UpdateCost(CostModel costChanges)
        {
            throw new NotImplementedException();
        }

        public CostModel DeleteCost(int id)
        {
            throw new NotImplementedException();
        }

        public void AssignCost(int tripMemberUserId, int costId)
        {
            throw new NotImplementedException();
        }
    }
}
