using System.Collections.Generic;
using UrlShortenerApi.Models;

namespace UrlShortenerApi.Repositories
{
    public interface IHeaderRepository
    {
        void Add(Microsoft.AspNetCore.Http.IHeaderDictionary request, int urlID);
        void Add(Header item);
    }
}
