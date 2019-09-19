using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using Nexus.Link.Libraries.Core.Storage.Model;
using Nexus.Link.Libraries.Crud.Interfaces;
using Nexus.Link.Libraries.Crud.Web.RestClient;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.CustomerServiceManagement;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.CustomerServiceManagement.Model;

namespace AcmeCorp.BusinessApi.Service.RestClients.Capabilities.CustomerServiceManagement
{
    /// <inheritdoc cref="IServiceConfigurationService" />
    public class CustomerEndUserRestClient : ICustomerEndUserService
    {
        private readonly CrudSlaveToMasterRestClient<ServiceConfiguration, ServiceConfiguration, string> _serviceConfigurationClient;

        /// <inheritdoc />
        public CustomerEndUserRestClient(string baseUri, HttpClient httpClient, ServiceClientCredentials credentials)
        {
            _serviceConfigurationClient = new CrudSlaveToMasterRestClient<ServiceConfiguration, ServiceConfiguration, string>(baseUri, httpClient, credentials, "CustomerEndUsers", "ServiceConfigurations");
        }

        /// <inheritdoc />
        public async Task<PageEnvelope<ServiceConfiguration>> ReadChildrenWithPagingAsync(string parentId, int offset, int? limit = null,
            CancellationToken token = new CancellationToken())
        {
            return await _serviceConfigurationClient.ReadChildrenWithPagingAsync(parentId, offset, limit, token);
        }
    }
}