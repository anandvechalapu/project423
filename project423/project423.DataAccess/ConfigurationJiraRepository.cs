using System.Data;
using System.Threading.Tasks;
using project423.DTO;

namespace project423
{
    public class ConfigurationJiraRepository
    {
        private readonly IDbConnection dbConnection;

        public ConfigurationJiraRepository(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public async Task<ConfigurationJiraModel> GetConfigurationJiraModelById(int id)
        {
            var query = "SELECT * FROM ConfigurationJira WHERE Id = @Id;";
            var parameters = new { Id = id };

            using (var reader = await dbConnection.ExecuteReaderAsync(query, parameters))
            {
                if (reader.Read())
                {
                    return new ConfigurationJiraModel
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("Id")),
                        SacralAiWebsite = reader.GetString(reader.GetOrdinal("SacralAiWebsite")),
                        JiraSoftwareUsername = reader.GetString(reader.GetOrdinal("JiraSoftwareUsername")),
                        JiraSoftwarePassword = reader.GetString(reader.GetOrdinal("JiraSoftwarePassword")),
                        JiraSoftwareURL = reader.GetString(reader.GetOrdinal("JiraSoftwareURL")),
                        RepositoryName = reader.GetString(reader.GetOrdinal("RepositoryName")),
                        ListTitle = reader.GetString(reader.GetOrdinal("ListTitle")),
                        ListUserName = reader.GetString(reader.GetOrdinal("ListUserName")),
                        ListURL = reader.GetString(reader.GetOrdinal("ListURL")),
                        ListAction = reader.GetString(reader.GetOrdinal("ListAction")),
                        EntriesToDisplay = reader.GetInt32(reader.GetOrdinal("EntriesToDisplay")),
                        Pagination = reader.GetInt32(reader.GetOrdinal("Pagination"))
                    };
                }

                return null;
            }
        }

        public async Task<int> CreateConfigurationJiraAsync(ConfigurationJiraModel model)
        {
            var query = @"INSERT INTO ConfigurationJira (SacralAiWebsite, JiraSoftwareUsername, JiraSoftwarePassword, JiraSoftwareURL, RepositoryName, ListTitle, ListUserName, ListURL, ListAction, EntriesToDisplay, Pagination)
                          VALUES (@SacralAiWebsite, @JiraSoftwareUsername, @JiraSoftwarePassword, @JiraSoftwareURL, @RepositoryName, @ListTitle, @ListUserName, @ListURL, @ListAction, @EntriesToDisplay, @Pagination);
                          SELECT CAST(SCOPE_IDENTITY() as int);";
            var parameters = new
            {
                model.SacralAiWebsite,
                model.JiraSoftwareUsername,
                model.JiraSoftwarePassword,
                model.JiraSoftwareURL,
                model.RepositoryName,
                model.ListTitle,
                model.ListUserName,
                model.ListURL,
                model.ListAction,
                model.EntriesToDisplay,
                model.Pagination
            };

            return await dbConnection.ExecuteScalarAsync<int>(query, parameters);
        }

        public async Task UpdateConfigurationJiraAsync(ConfigurationJiraModel model)
        {
            var query = @"UPDATE ConfigurationJira
                          SET SacralAiWebsite = @SacralAiWebsite,
                              JiraSoftwareUsername = @JiraSoftwareUsername,
                              JiraSoftwarePassword = @JiraSoftwarePassword,
                              JiraSoftwareURL = @JiraSoftwareURL,
                              RepositoryName = @RepositoryName,
                              ListTitle = @ListTitle,
                              ListUserName = @ListUserName,
                              ListURL = @ListURL,
                              ListAction = @ListAction,
                              EntriesToDisplay = @EntriesToDisplay,
                              Pagination = @Pagination
                          WHERE Id = @Id;";
            var parameters = new
            {
                model.Id,
                model.SacralAiWebsite,
                model.JiraSoftwareUsername,
                model.JiraSoftwarePassword,
                model.JiraSoftwareURL,
                model.RepositoryName,
                model.ListTitle,
                model.ListUserName,
                model.List