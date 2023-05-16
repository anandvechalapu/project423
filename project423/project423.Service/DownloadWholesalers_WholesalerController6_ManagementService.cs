using project423.DataAccess;
using project423.DTO;

namespace project423.Service
{
    public class DownloadWholesalers_WholesalerController6_ManagementService
    {
        public async Task<List<WholesalerDTO>> DownloadWholesalers_WholesalerController6_ManagementService()
        {
            var wholesalerDataAccess = new WholesalerDataAccess();
            var wholesalers = await wholesalerDataAccess.DownloadWholesalers_WholesalerController6_ManagementService();
            return wholesalers;
        }
    }
}