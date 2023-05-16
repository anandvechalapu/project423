namespace project423
{
    public class LeaveEncashmentCalculationRepository : ILeaveEncashmentCalculationRepository
    {
        private string _connectionString;

        public LeaveEncashmentCalculationRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> CreateLeaveEncashmentCalculationAsync(LeaveEncashmentCalculationModel model)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                string query = @"INSERT INTO LeaveEncashmentCalculation (LeaveAccrued, LeaveAvailed, LeaveEncashment)
                                VALUES (@LeaveAccrued, @LeaveAvailed, @LeaveEncashment);
                                SELECT LAST_INSERT_ID();";
                
                return await conn.QuerySingleAsync<int>(query,
                    new { model.LeaveAccrued, model.LeaveAvailed, model.LeaveEncashment });
            }
        }

        public async Task<LeaveEncashmentCalculationModel> GetLeaveEncashmentCalculationByIdAsync(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                string query = @"SELECT * FROM LeaveEncashmentCalculation WHERE Id = @Id;";
                
                return (await conn.QueryAsync<LeaveEncashmentCalculationModel>(query, new { Id = id })).SingleOrDefault();
            }
        }

        public async Task<bool> UpdateLeaveEncashmentCalculationAsync(LeaveEncashmentCalculationModel model)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                string query = @"UPDATE LeaveEncashmentCalculation SET 
                                    LeaveAccrued = @LeaveAccrued, 
                                    LeaveAvailed = @LeaveAvailed, 
                                    LeaveEncashment = @LeaveEncashment 
                                WHERE Id = @Id;";
                
                return await conn.ExecuteAsync(query,
                    new { model.Id, model.LeaveAccrued, model.LeaveAvailed, model.LeaveEncashment }) > 0;
            }
        }

        public async Task<bool> DeleteLeaveEncashmentCalculationAsync(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                string query = @"DELETE FROM LeaveEncashmentCalculation WHERE Id = @Id;";
                
                return await conn.ExecuteAsync(query, new { Id = id }) > 0;
            }
        }
    }

    public interface ILeaveEncashmentCalculationRepository
    {
        Task<int> CreateLeaveEncashmentCalculationAsync(LeaveEncashmentCalculationModel model);

        Task<LeaveEncashmentCalculationModel> GetLeaveEncashmentCalculationByIdAsync(int id);

        Task<bool> UpdateLeaveEncashmentCalculationAsync(LeaveEncashmentCalculationModel model);

        Task<bool> DeleteLeaveEncashmentCalculationAsync(int id);
    }
}