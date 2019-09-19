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
    /// <inheritdoc cref="IServiceService" />
    public class ServiceRestClient : IServiceService
    {
        private readonly CrudRestClient<Libraries.Contracts.Capabilities.CustomerServiceManagement.Model.Service, string> _client;

        /// <inheritdoc />
        public ServiceRestClient(string baseUri, HttpClient httpClient, ServiceClientCredentials credentials)
        {
            _client = new CrudRestClient<Libraries.Contracts.Capabilities.CustomerServiceManagement.Model.Service, string>(baseUri, httpClient, credentials);
        }

        /// <inheritdoc />
        public async Task<Libraries.Contracts.Capabilities.CustomerServiceManagement.Model.Service> ReadAsync(string id, CancellationToken token = new CancellationToken())
        {
            return await _client.ReadAsync(id, token);
        }
    }
}