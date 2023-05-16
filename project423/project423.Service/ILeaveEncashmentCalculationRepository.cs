using project423.DTO;

namespace project423.Service
{
    public interface ILeaveEncashmentCalculationRepository
    {
        Task<int> CreateLeaveEncashmentCalculationAsync(LeaveEncashmentCalculationModel model);
        Task<LeaveEncashmentCalculationModel> GetLeaveEncashmentCalculationByIdAsync(int id);
        Task<bool> UpdateLeaveEncashmentCalculationAsync(LeaveEncashmentCalculationModel model);
        Task<bool> DeleteLeaveEncashmentCalculationAsync(int id);
    }
}