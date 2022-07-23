using DocsSearchEngine.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DocsSearchEngine.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SearchDocsController : ControllerBase
    {
        private readonly ILogger<SearchDocsController> logger;

        private readonly ISearchDocManager searchDocManager;
        public SearchDocsController(ILogger<SearchDocsController> logger, ISearchDocManager searchDocManager)
        {
            this.logger = logger;
            this.searchDocManager = searchDocManager;
        }

        [HttpPost]
        public async Task<IActionResult> GetRsults( DocsSearchEngine.Models.SearchFilter searchFilter)
        {
            try
            {
                var results = await searchDocManager.Execute(searchFilter.Content);
                return Ok(results);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
