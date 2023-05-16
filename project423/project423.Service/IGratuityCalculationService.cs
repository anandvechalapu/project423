using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using project423.DTO;

namespace project423.Service
{
    public interface IGratuityCalculationService
    {
        // Get All Gratuity Calculation Information
        Task<List<GratuityCalculationModel>> GetAllGratuityCalculationInfoAsync();

        // Get Gratuity Calculation Information By Id
        Task<GratuityCalculationModel> GetGratuityCalculationInfoByIdAsync(int id);

        // Insert Gratuity Calculation Information
        Task<int> InsertGratuityCalculationInfoAsync(GratuityCalculationModel model);

        // Update Gratuity Calculation Information
        Task<int> UpdateGratuityCalculationInfoAsync(GratuityCalculationModel model);

        // Delete Gratuity Calculation Information
        Task<int> DeleteGratuityCalculationInfoAsync(int id);
    }
}