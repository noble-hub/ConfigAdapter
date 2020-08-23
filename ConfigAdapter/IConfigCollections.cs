using Microsoft.Extensions.Configuration;

namespace ConfigAdapter
{
    public interface IConfigCollections
    {
        IConfiguration Configuration { get; }
    }
}
