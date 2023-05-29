namespace project423
{
    public class ConfigurationJiraModel
    {
        public int Id { get; set; }
        public string SacralAiWebsite { get; set; }
        public string JiraSoftwareUsername { get; set; }
        public string JiraSoftwarePassword { get; set; }
        public string JiraSoftwareURL { get; set; }
        public string RepositoryName { get; set; }
        public string ListTitle { get; set; }
        public string ListUserName { get; set; }
        public string ListURL { get; set; }
        public string ListAction { get; set; }
        public int EntriesToDisplay { get; set; }
        public int Pagination { get; set; }
    }
}