using DocsSearchEngine.Agent;
using DocsSearchEngine.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DocsSearchEngine.BusinessLogic.Managers
{
    public class SearchDocManager: ISearchDocManager
    {
        private readonly IAzureSearchClient azureSearchClient;
        public SearchDocManager(IAzureSearchClient azureSearchClient)
        {
            this.azureSearchClient = azureSearchClient;
        }

        public async Task<object> Execute(string searchText)
        {
            var results = await this.azureSearchClient.RunQueries(searchText);
            return results;
        }
    }
}
