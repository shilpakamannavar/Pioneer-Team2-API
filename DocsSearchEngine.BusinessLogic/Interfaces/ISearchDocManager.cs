using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DocsSearchEngine.BusinessLogic.Interfaces
{
    public interface ISearchDocManager
    {
        Task<Object> Execute(string searchText);
    }
}
