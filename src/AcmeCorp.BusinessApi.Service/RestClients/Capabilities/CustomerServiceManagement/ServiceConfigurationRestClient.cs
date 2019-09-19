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
    public class ServiceConfigurationRestClient : IServiceConfigurationService
    {
        private readonly CrudRestClient<ServiceConfiguration, string> _client;
        private readonly CrudSlaveToMasterRestClient<ServicePackage, ServicePackage, string> _caseClient;

        /// <inheritdoc />
        public ServiceConfigurationRestClient(string baseUri, HttpClient httpClient, ServiceClientCredentials credentials)
        {
            _client = new CrudRestClient<ServiceConfiguration, string>(baseUri, httpClient, credentials);
            _caseClient = new CrudSlaveToMasterRestClient<ServicePackage, ServicePackage, string>(baseUri, httpClient, credentials, "ServiceConfigurations", "ServicePackages");
        }

        /// <inheritdoc />
        public async Task<PageEnvelope<ServicePackage>> ReadChildrenWithPagingAsync(string parentId, int offset, int? limit = null,
            CancellationToken token = new CancellationToken())
        {
            return await _caseClient.ReadChildrenWithPagingAsync(parentId, offset, limit, token);
        }

        /// <inheritdoc />
        public async Task<ServiceConfiguration> ReadAsync(string id, CancellationToken token = new CancellationToken())
        {
            return await _client.ReadAsync(id, token);
        }
    }
}