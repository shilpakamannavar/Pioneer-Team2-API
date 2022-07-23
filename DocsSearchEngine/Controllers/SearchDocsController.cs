using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DocsSearchEngine.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SearchDocsController : ControllerBase
    {
        private readonly ILogger<SearchDocsController> _logger;
        public SearchDocsController(ILogger<SearchDocsController> logger)
        {
            this._logger = logger;
        }

        [HttpPost]
        public ActionResult GetRsults() {

            return null;
        }        
    }
}
