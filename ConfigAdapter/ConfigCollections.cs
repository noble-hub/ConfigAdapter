using Microsoft.Extensions.Configuration;

namespace ConfigAdapter
{
    public class ConfigCollections : IConfigCollections
    {
        IConfiguration configuration;

        public ConfigCollections(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public IConfiguration Configuration
        {
            get
            {
                IConfigurationRoot config = new ConfigurationBuilder()
                .Add(new FrameworkConfig())
                .AddConfiguration(configuration)
                .Build();

                return config;
            }
        }
    }
}
