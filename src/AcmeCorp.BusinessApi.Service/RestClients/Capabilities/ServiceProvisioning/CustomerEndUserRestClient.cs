using System.Net.Http;
using Microsoft.Rest;
using Nexus.Link.Libraries.Crud.Web.RestClient;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.ServiceProvisioning;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.ServiceProvisioning.Model;

namespace AcmeCorp.BusinessApi.Service.RestClients.Capabilities.ServiceProvisioning
{
    /// <inheritdoc cref="ICaseService" />
    public class CustomerEndUserRestClient : CrudSlaveToMasterRestClient<CaseCreate, Case, string>, ICustomerEndUserService
    {
        /// <inheritdoc />
        public CustomerEndUserRestClient(string baseUri, HttpClient httpClient, ServiceClientCredentials credentials) : base(baseUri, httpClient, credentials, "EndUsers", "Cases")
        {
        }
    }
}