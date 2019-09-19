using System.Net.Http;
using Microsoft.Rest;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.ServiceProvisioning;

namespace AcmeCorp.BusinessApi.Service.RestClients.Capabilities.ServiceProvisioning
{
    /// <inheritdoc />
    public class ServiceProvisioningCapability : IServiceProvisioningCapability
    {
        /// <inheritdoc />
        public ServiceProvisioningCapability(string baseUrl, HttpClient httpClient, ServiceClientCredentials credentials)
        {
            Case = new CaseRestClient($"{baseUrl}/Cases", httpClient, credentials);
            CustomerEndUser = new CustomerEndUserRestClient($"{baseUrl}/CustomerEndUsers", httpClient, credentials);
        }

        /// <inheritdoc />
        public ICaseService Case { get; set; }

        /// <inheritdoc />
        public ICustomerEndUserService CustomerEndUser { get; }
    }
}
