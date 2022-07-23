using Azure;
using Azure.Search.Documents.Models;
using DocsSearchEngine.Agent.model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DocsSearchEngine.Agent
{
    public interface IAzureSearchClient
    {
        Task<List<SearchResult<DocDetails>>> RunQueries(string SearchText);
    }
}
