URL,
                model.ListAction,
                model.EntriesToDisplay,
                model.Pagination
            };

            await dbConnection.ExecuteAsync(query, parameters);
        }
    }
}

namespace project423.Service
{
    using System.Data;
    using System.Threading.Tasks;
    using project423.DTO;

    public interface IConfigurationJiraRepository
    {
        Task<ConfigurationJiraModel> GetConfigurationJiraModelById(int id);
        Task<int> CreateConfigurationJiraAsync(ConfigurationJiraModel model);
        Task UpdateConfigurationJiraAsync(ConfigurationJiraModel model);
    }
}