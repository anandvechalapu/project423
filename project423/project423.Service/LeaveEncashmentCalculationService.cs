namespace project423.Repository
{
    public interface ILeaveEncashmentCalculationRepository
    {
        Task<int> CreateLeaveEncashmentCalculationAsync(LeaveEncashmentCalculationModel model);
        Task<LeaveEncashmentCalculationModel> GetLeaveEncashmentCalculationByIdAsync(int id);
        Task<bool> UpdateLeaveEncashmentCalculationAsync(LeaveEncashmentCalculationModel model);
        Task<bool> DeleteLeaveEncashmentCalculationAsync(int id);
    }

    public class LeaveEncashmentCalculationRepository : ILeaveEncashmentCalculationRepository
    {
        public async Task<int> CreateLeaveEncashmentCalculationAsync(LeaveEncashmentCalculationModel model)
        {
            //Code to create leave encashment calculation
            return 1;
        }

        public async Task<LeaveEncashmentCalculationModel> GetLeaveEncashmentCalculationByIdAsync(int id)
        {
            //Code to get leave encashment calculation by id
            return new LeaveEncashmentCalculationModel();
        }

        public async Task<bool> UpdateLeaveEncashmentCalculationAsync(LeaveEncashmentCalculationModel model)
        {
            //Code to update leave encashment calculation
            return true;
        }

        public async Task<bool> DeleteLeaveEncashmentCalculationAsync(int id)
        {
            //Code to delete leave encashment calculation
            return true;
        }
    }
}