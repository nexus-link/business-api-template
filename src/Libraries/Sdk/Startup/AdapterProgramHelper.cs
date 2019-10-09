using Microsoft.Extensions.Configuration;
using Nexus.Link.Services.Implementations.Adapter.Startup;

namespace AcmeCorp.BusinessApi.Libraries.Sdk.Startup
{
    /// <summary>
    /// Helper class for updating the configuration with data from the configuration DB.
    /// </summary>
    public static class AdapterProgramHelper
    {
        /// <summary>
        /// Use this in Program.cs to update the configuration with data from the configuration DB.
        /// </summary>
        public static void AddConfiguration(IConfigurationBuilder builder)
        {
            NexusAdapterProgramHelper.AddConfiguration(builder);
        }
    }
}
