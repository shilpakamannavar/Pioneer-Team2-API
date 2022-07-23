using Azure;
using Azure.Search.Documents;
using Azure.Search.Documents.Indexes;
using Azure.Search.Documents.Models;
using DocsSearchEngine.Agent.model;
using DocsSearchEngine.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocsSearchEngine.Agent
{
    public class AzureSearchClient: IAzureSearchClient
    {

        private AzureSearchConfig searchConfig;

        private SearchClient srchclient;

        private SearchIndexClient adminClient;
        public AzureSearchClient(IOptions<AzureSearchConfig> options)
        {
            searchConfig = options.Value;
            Uri serviceEndpoint = new Uri($"https://{searchConfig.ServiceName}.search.windows.net/");
            AzureKeyCredential credential = new AzureKeyCredential(searchConfig.ApiKey);
            adminClient = new SearchIndexClient(serviceEndpoint, credential);

            // Create a SearchClient to load and query documents
            srchclient = new SearchClient(serviceEndpoint, searchConfig.IndexName, credential);
        }


        public async Task<List<SearchResult<DocDetails>>> RunQueries(string SearchText)
        {
            try
            {
                List<SearchResult<DocDetails>> result;
                var options = new SearchOptions()
                {
                   // OrderBy = { "metadata_creation_date desc" }
                };
                var response = srchclient.Search<DocDetails>(SearchText, options).Value.GetResultsAsync();
                result = await response.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
