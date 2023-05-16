using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using project423.DTO;
using project423.Service;

namespace project423.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class GratuityCalculationController : ControllerBase
    {
        private readonly GratuityCalculationService _gratuityCalculationService;

        public GratuityCalculationController(GratuityCalculationService gratuityCalculationService)
        {
            _gratuityCalculationService = gratuityCalculationService;
        }

        // Get All Gratuity Calculation Information
        [HttpGet("GetAllGratuityCalculationInfo")]
        public async Task<IActionResult> GetAllGratuityCalculationInfo()
        {
            List<GratuityCalculationModel> models = await _gratuityCalculationService.GetAllGratuityCalculationInfoAsync();
            return Ok(models);
        }

        // Get Gratuity Calculation Information By Id
        [HttpGet("GetGratuityCalculationInfoById/{id}")]
        public async Task<IActionResult> GetGratuityCalculationInfoById(int id)
        {
            GratuityCalculationModel model = await _gratuityCalculationService.GetGratuityCalculationInfoByIdAsync(id);
            if (model == null)
            {
                return NotFound("No record found against this id.");
            }

            return Ok(model);
        }

        // Insert Gratuity Calculation Information
        [HttpPost("InsertGratuityCalculationInfo")]
        public async Task<IActionResult> InsertGratuityCalculationInfo(GratuityCalculationModel model)
        {
            int result = await _gratuityCalculationService.InsertGratuityCalculationInfoAsync(model);
            if (result > 0)
            {
                return Ok("Gratuity Calculation infomation added successfully.");
            }

            return BadRequest("Gratuity Calculation infomation could not be added.");
        }

        // Update Gratuity Calculation Information
        [HttpPut("UpdateGratuityCalculationInfo")]
        public async Task<IActionResult> UpdateGratuityCalculationInfo(GratuityCalculationModel model)
        {
            int result = await _gratuityCalculationService.UpdateGratuityCalculationInfoAsync(model);
            if (result > 0)
            {
                return Ok("Gratuity Calculation infomation updated successfully.");
            }

            return BadRequest("Gratuity Calculation infomation could not be updated.");
        }

        // Delete Gratuity Calculation Information
        [HttpDelete("DeleteGratuityCalculationInfo/{id}")]
        public async Task<IActionResult> DeleteGratuityCalculationInfo(int id)
        {
            int result = await _gratuityCalculationService.DeleteGratuityCalculationInfoAsync(id);
            if (result > 0)
            {
                return Ok("Gratuity Calculation infomation deleted successfully.");
            }

            return BadRequest("Gratuity Calculation infomation could not be deleted.");
        }
    }
}