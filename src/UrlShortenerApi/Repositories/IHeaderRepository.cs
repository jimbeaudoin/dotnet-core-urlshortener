using System.Collections.Generic;
using UrlShortenerApi.Models;

namespace UrlShortenerApi.Repositories
{
    public interface IHeaderRepository
    {
        void Add(Microsoft.AspNetCore.Http.IHeaderDictionary headers, System.Guid urlId);
        void Add(Header item);
    }
}
