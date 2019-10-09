using Nexus.Link.Libraries.Core.Platform.Authentication;
using Nexus.Link.Services.Contracts.Capabilities.Integration;
using Nexus.Link.Services.Implementations.Adapter.Capabilities.Integration;

namespace AcmeCorp.BusinessApi.Libraries.Sdk
{
    /// <summary>
    /// Singleton class to access functionality in the Business API.
    /// </summary>
    internal class CapabilityImplementations
    {
        private static readonly object ClassLock = new object();
        /// <summary>
        /// The singleton instance. Must be initialized with <see cref="InitializeSingleton"/>.
        /// </summary>
        public static CapabilityImplementations Instance { get; private set; }

        /// <summary>
        /// Initialize <see cref="Instance"/>.
        /// </summary>
        public static void InitializeSingleton(string endpoint, AuthenticationCredentials credentials)
        {
            Instance = new CapabilityImplementations(endpoint, credentials);
        }

        /// <summary>
        /// Access to the Business API <see cref="IIntegrationCapability"/> implementation.
        /// </summary>
        public IIntegrationCapability Integration
        {
            get
            {
                lock (ClassLock)
                {
                    if (_integrationCapability != null) return _integrationCapability;
                    var baseUrl = $"{_endpoint}/api/Integration/v1";
                    _integrationCapability =
                        new IntegrationCapability(baseUrl, _credentials);
                    return _integrationCapability;
                }
            }

        }

        private IIntegrationCapability _integrationCapability;
        private readonly string _endpoint;
        private readonly AuthenticationCredentials _credentials;

        private CapabilityImplementations(string endpoint, AuthenticationCredentials credentials)
        {
            _endpoint = endpoint;
            _credentials = credentials;
        }
    }
}
