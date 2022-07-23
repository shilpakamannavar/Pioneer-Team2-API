using System;
using System.Collections.Generic;
using System.Text;

namespace DocsSearchEngine.Models
{
    public class AzureSearchConfig
    {
        public string ServiceName { get; set; }
        public string IndexName { get; set; }
        public string ApiKey { get; set; }
    }
}
