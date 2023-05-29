namespace project423.Service
{
    using project423.DTO;
    using System.Threading.Tasks;

    public interface IConfigurationJiraService
    {
        Task<ConfigurationJiraModel> GetConfigurationJiraModelByIdAsync(int id);
        Task<int> CreateConfigurationJiraAsync(ConfigurationJiraModel model);
        Task UpdateConfigurationJiraAsync(ConfigurationJiraModel model);
        Task DeleteConfigurationJiraAsync(int id);
    }
}


//Reference
//using project423.DTO;