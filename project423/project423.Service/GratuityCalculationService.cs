using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using project423.DataAccess;
using project423.DTO;

namespace project423.Service
{
    public class GratuityCalculationService: IGratuityCalculationService
    {
        private readonly GratuityCalculationRepository _gratuityCalculationRepository;

        public GratuityCalculationService(GratuityCalculationRepository gratuityCalculationRepository)
        {
            _gratuityCalculationRepository = gratuityCalculationRepository;
        }

        // Get All Gratuity Calculation Information
        public async Task<List<GratuityCalculationModel>> GetAllGratuityCalculationInfoAsync()
        {
            DataTable table = await _gratuityCalculationRepository.GetAllGratuityCalculationInfoAsync();
            List<GratuityCalculationModel> models = new List<GratuityCalculationModel>();
            foreach (DataRow row in table.Rows)
            {
                GratuityCalculationModel model = new GratuityCalculationModel
                {
                    Id = Convert.ToInt32(row["Id"]),
                    EmployeeName = row["EmployeeName"].ToString(),
                    GratuityAmount = Convert.ToDouble(row["GratuityAmount"]),
                    Salary = Convert.ToDouble(row["Salary"]),
                    YearsOfService = Convert.ToInt32(row["YearsOfService"])
                };
                models.Add(model);
            }

            return models;
        }

        // Get Gratuity Calculation Information By Id
        public async Task<GratuityCalculationModel> GetGratuityCalculationInfoByIdAsync(int id)
        {
            return await _gratuityCalculationRepository.GetGratuityCalculationInfoByIdAsync(id);
        }

        // Insert Gratuity Calculation Information
        public async Task<int> InsertGratuityCalculationInfoAsync(GratuityCalculationModel model)
        {
            return await _gratuityCalculationRepository.InsertGratuityCalculationInfoAsync(model);
        }

        // Update Gratuity Calculation Information
        public async Task<int> UpdateGratuityCalculationInfoAsync(GratuityCalculationModel model)
        {
            return await _gratuityCalculationRepository.UpdateGratuityCalculationInfoAsync(model);
        }

        // Delete Gratuity Calculation Information
        public async Task<int> DeleteGratuityCalculationInfoAsync(int id)
        {
            return await _gratuityCalculationRepository.DeleteGratuityCalculationInfoAsync(id);
        }
    }
}