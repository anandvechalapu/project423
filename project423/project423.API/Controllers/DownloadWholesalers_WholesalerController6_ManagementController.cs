using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using project423.DataAccess;
using project423.DTO;
using project423.Service;

namespace project423.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadWholesalers_WholesalerController6_ManagementController : ControllerBase
    {
        private readonly DownloadWholesalers_WholesalerController6_ManagementService _downloadWholesalers_WholesalerController6_ManagementService;

        public DownloadWholesalers_WholesalerController6_ManagementController(DownloadWholesalers_WholesalerController6_ManagementService downloadWholesalers_WholesalerController6_ManagementService)
        {
            _downloadWholesalers_WholesalerController6_ManagementService = downloadWholesalers_WholesalerController6_ManagementService;
        }

        [HttpGet]
        public async Task<ActionResult<List<WholesalerDTO>>> Get()
        {
            var wholesalers = await _downloadWholesalers_WholesalerController6_ManagementService.DownloadWholesalers_WholesalerController6_ManagementService();
            return Ok(wholesalers);
        }
    }
}