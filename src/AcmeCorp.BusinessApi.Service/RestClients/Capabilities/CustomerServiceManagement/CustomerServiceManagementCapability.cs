using System.Net.Http;
using Microsoft.Rest;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.CustomerServiceManagement;

namespace AcmeCorp.BusinessApi.Service.RestClients.Capabilities.CustomerServiceManagement
{
    /// <inheritdoc />
    public class CustomerServiceManagementCapability : ICustomerServiceManagementCapability
    {
        /// <inheritdoc />
        public CustomerServiceManagementCapability(string baseUrl, HttpClient httpClient, ServiceClientCredentials credentials)
        {
            CustomerEndUserService = new CustomerEndUserRestClient($"{baseUrl}/CustomerEndUsers", httpClient, credentials);
            ServiceConfiguration = new ServiceConfigurationRestClient($"{baseUrl}/ServiceConfigurations", httpClient, credentials);
            ServicePackage = new ServicePackageRestClient($"{baseUrl}/ServicePackages", httpClient, credentials);
            Service = new ServiceRestClient($"{baseUrl}/Services", httpClient, credentials);
        }

        /// <inheritdoc />
        public ICustomerEndUserService CustomerEndUserService { get; }

        /// <inheritdoc />
        public IServiceConfigurationService ServiceConfiguration { get; }

        /// <inheritdoc />
        public IServicePackageService ServicePackage { get; }

        /// <inheritdoc />
        public IServiceService Service { get; }
    }
}
