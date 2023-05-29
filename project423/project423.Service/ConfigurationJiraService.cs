URL,
                model.ListAction,
                model.EntriesToDisplay,
                model.Pagination
            };

            await dbConnection.ExecuteScalarAsync<int>(query, parameters);
        }

        public async Task DeleteConfigurationJiraAsync(int id)
        {
            var query = "DELETE FROM ConfigurationJira WHERE Id = @Id;";
            var parameters = new { Id = id };

            await dbConnection.ExecuteScalarAsync<int>(query, parameters);
        }
    }

    public class ConfigurationJiraService
    {
        private readonly ConfigurationJiraRepository configurationJiraRepository;

        public ConfigurationJiraService(ConfigurationJiraRepository configurationJiraRepository)
        {
            this.configurationJiraRepository = configurationJiraRepository;
        }

        public async Task<ConfigurationJiraModel> GetConfigurationJiraModelByIdAsync(int id)
        {
            return await configurationJiraRepository.GetConfigurationJiraModelById(id);
        }

        public async Task<int> CreateConfigurationJiraAsync(ConfigurationJiraModel model)
        {
            return await configurationJiraRepository.CreateConfigurationJiraAsync(model);
        }

        public async Task UpdateConfigurationJiraAsync(ConfigurationJiraModel model)
        {
            await configurationJiraRepository.UpdateConfigurationJiraAsync(model);
        }

        public async Task DeleteConfigurationJiraAsync(int id)
        {
            await configurationJiraRepository.DeleteConfigurationJiraAsync(id);
        }
    }
}