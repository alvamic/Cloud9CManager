using C9_CostManager.Models;

namespace C9_CostManager.Services
{
    public interface ICostRepository
    {

        //Read
        CostModel GetCost(int id);
        //Create
        void AddCost(CostModel c);

        //Update
        CostModel UpdateCost(CostModel costChanges);
        //Delete
        CostModel DeleteCost(int id);

        //assign cost -> using junction table 

        void AssignCost(int tripMemberUserId, int costId);
    }
}
