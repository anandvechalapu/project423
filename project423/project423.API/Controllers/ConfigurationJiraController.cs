namespace project423.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationJiraController : ControllerBase
    {
        private readonly ConfigurationJiraService configurationJiraService;

        public ConfigurationJiraController(ConfigurationJiraService configurationJiraService)
        {
            this.configurationJiraService = configurationJiraService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ConfigurationJiraModel>> GetConfigurationJiraModelByIdAsync(int id)
        {
            var result = await configurationJiraService.GetConfigurationJiraModelByIdAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateConfigurationJiraAsync(ConfigurationJiraModel model)
        {
            return await configurationJiraService.CreateConfigurationJiraAsync(model);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateConfigurationJiraAsync(ConfigurationJiraModel model)
        {
            await configurationJiraService.UpdateConfigurationJiraAsync(model);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteConfigurationJiraAsync(int id)
        {
            await configurationJiraService.DeleteConfigurationJiraAsync(id);

            return NoContent();
        }
    }
}