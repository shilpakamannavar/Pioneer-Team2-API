using System.Diagnostics.CodeAnalysis;

namespace DocsSearchEngine.Models
{
    [ExcludeFromCodeCoverage]
    public class SearchFilter
    {
        public string Content { get; set; }
        public string Metadata { get; set; }
    }
}
