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
    /// <inheritdoc cref="IServicePackageService" />
    public class ServicePackageRestClient : IServicePackageService
    {
        private readonly CrudRestClient<ServicePackage, string> _client;
        private readonly CrudSlaveToMasterRestClient<Libraries.Contracts.Capabilities.CustomerServiceManagement.Model.Service, Libraries.Contracts.Capabilities.CustomerServiceManagement.Model.Service, string> _caseClient;

        /// <inheritdoc />
        public ServicePackageRestClient(string baseUri, HttpClient httpClient, ServiceClientCredentials credentials)
        {
            _client = new CrudRestClient<ServicePackage, string>(baseUri, httpClient, credentials);
            _caseClient = new CrudSlaveToMasterRestClient<Libraries.Contracts.Capabilities.CustomerServiceManagement.Model.Service, Libraries.Contracts.Capabilities.CustomerServiceManagement.Model.Service, string>(baseUri, httpClient, credentials, "ServicePackages", "Services");
        }

        /// <inheritdoc />
        public async Task<int> NumberOfActive(string servicePackageId, string customerId, CancellationToken token = default(CancellationToken))
        {
            var count = await _client.GetAsync<int>($"{servicePackageId}/Customer/{customerId}/NumberOfActive", null, token);
            return count;
        }

        /// <inheritdoc />
        public async Task<PageEnvelope<Libraries.Contracts.Capabilities.CustomerServiceManagement.Model.Service>> ReadChildrenWithPagingAsync(string parentId, int offset, int? limit = null,
            CancellationToken token = new CancellationToken())
        {
            return await _caseClient.ReadChildrenWithPagingAsync(parentId, offset, limit, token);
        }

        /// <inheritdoc />
        public async Task<ServicePackage> ReadAsync(string id, CancellationToken token = new CancellationToken())
        {
            return await _client.ReadAsync(id, token);
        }
    }
}