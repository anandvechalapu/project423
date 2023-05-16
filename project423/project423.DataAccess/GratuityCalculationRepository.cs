using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using project423.DTO;

namespace project423
{
    public class GratuityCalculationRepository
    {
        private readonly SqlConnection connection;

        public GratuityCalculationRepository(SqlConnection connection)
        {
            this.connection = connection;
        }

        // Get All Gratuity Calculation Information
        public async Task<DataTable> GetAllGratuityCalculationInfoAsync()
        {
            var command = new SqlCommand("SELECT * FROM GratuityCalculation", connection);

            DataTable table = new DataTable();
            await command.ExecuteReaderAsync().ContinueWith(t =>
            {
                using (var reader = t.Result)
                    table.Load(reader);
            });

            return table;
        }

        // Get Gratuity Calculation Information By Id
        public async Task<GratuityCalculationModel> GetGratuityCalculationInfoByIdAsync(int id)
        {
            var command = new SqlCommand("SELECT * FROM GratuityCalculation WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);

            GratuityCalculationModel model = null;
            await command.ExecuteReaderAsync().ContinueWith(t =>
            {
                using (var reader = t.Result)
                {
                    while (reader.Read())
                    {
                        model = new GratuityCalculationModel
                        {
                            Id = reader.GetInt32(0),
                            EmployeeName = reader.GetString(1),
                            GratuityAmount = reader.GetDouble(2),
                            Salary = reader.GetDouble(3),
                            YearsOfService = reader.GetInt32(4)
                        };
                    }
                }
            });

            return model;
        }

        // Insert Gratuity Calculation Information
        public async Task<int> InsertGratuityCalculationInfoAsync(GratuityCalculationModel model)
        {
            var command = new SqlCommand("INSERT INTO GratuityCalculation (EmployeeName, GratuityAmount, Salary, YearsOfService) " +
                                         "VALUES (@EmployeeName, @GratuityAmount, @Salary, @YearsOfService)", connection);
            command.Parameters.AddWithValue("@EmployeeName", model.EmployeeName);
            command.Parameters.AddWithValue("@GratuityAmount", model.GratuityAmount);
            command.Parameters.AddWithValue("@Salary", model.Salary);
            command.Parameters.AddWithValue("@YearsOfService", model.YearsOfService);

            return await command.ExecuteNonQueryAsync();
        }

        // Update Gratuity Calculation Information
        public async Task<int> UpdateGratuityCalculationInfoAsync(GratuityCalculationModel model)
        {
            var command = new SqlCommand("UPDATE GratuityCalculation SET " +
                                         "EmployeeName = @EmployeeName, GratuityAmount = @GratuityAmount, Salary = @Salary, YearsOfService = @YearsOfService " +
                                         "WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@EmployeeName", model.EmployeeName);
            command.Parameters.AddWithValue("@GratuityAmount", model.GratuityAmount);
            command.Parameters.AddWithValue("@Salary", model.Salary);
            command.Parameters.AddWithValue("@YearsOfService", model.YearsOfService);
            command.Parameters.AddWithValue("@Id", model.Id);

            return await command.ExecuteNonQueryAsync();
        }

        // Delete Gratuity Calculation Information
        public async Task<int> DeleteGratuityCalculationInfoAsync(int id)
        {
            var command = new SqlCommand("DELETE FROM GratuityCalculation WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);

            return await command.ExecuteNonQueryAsync();
        }
    }
}