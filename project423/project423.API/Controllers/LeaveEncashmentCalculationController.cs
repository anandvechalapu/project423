namespace project423.API
{
    [ApiController]
    [Route("[controller]")]
    public class LeaveEncashmentCalculationController : ControllerBase
    {
        private readonly LeaveEncashmentCalculationService _leaveEncashmentCalculationService;

        public LeaveEncashmentCalculationController(LeaveEncashmentCalculationService leaveEncashmentCalculationService)
        {
            _leaveEncashmentCalculationService = leaveEncashmentCalculationService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateLeaveEncashmentCalculationAsync(LeaveEncashmentCalculationDTO model)
        {
            var leaveEncashmentCalculationModel = new LeaveEncashmentCalculationModel
            {
                LeaveAccrued = model.LeaveAccrued,
                LeaveAvailed = model.LeaveAvailed,
                LeaveEncashment = model.LeaveEncashment
            };

            var id = await _leaveEncashmentCalculationService.CreateLeaveEncashmentCalculationAsync(leaveEncashmentCalculationModel);
            return Ok(id);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLeaveEncashmentCalculationByIdAsync(int id)
        {
            var leaveEncashmentCalculationModel = await _leaveEncashmentCalculationService.GetLeaveEncashmentCalculationByIdAsync(id);
            return Ok(leaveEncashmentCalculationModel);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateLeaveEncashmentCalculationAsync(LeaveEncashmentCalculationDTO model)
        {
            var leaveEncashmentCalculationModel = new LeaveEncashmentCalculationModel
            {
                Id = model.Id,
                LeaveAccrued = model.LeaveAccrued,
                LeaveAvailed = model.LeaveAvailed,
                LeaveEncashment = model.LeaveEncashment
            };

            var isUpdated = await _leaveEncashmentCalculationService.UpdateLeaveEncashmentCalculationAsync(leaveEncashmentCalculationModel);
            return Ok(isUpdated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLeaveEncashmentCalculationAsync(int id)
        {
            var isDeleted = await _leaveEncashmentCalculationService.DeleteLeaveEncashmentCalculationAsync(id);
            return Ok(isDeleted);
        }
    }
}