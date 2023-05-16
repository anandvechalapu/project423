using System.Data;
using System.Threading.Tasks;
using project423.DTO;

namespace project423.Service
{
    public interface IGratuityCalculationRepository
    {
        Task<DataTable> GetAllGratuityCalculationInfoAsync();
        Task<GratuityCalculationModel> GetGratuityCalculationInfoByIdAsync(int id);
        Task<int> InsertGratuityCalculationInfoAsync(GratuityCalculationModel model);
        Task<int> UpdateGratuityCalculationInfoAsync(GratuityCalculationModel model);
        Task<int> DeleteGratuityCalculationInfoAsync(int id);
    }
}