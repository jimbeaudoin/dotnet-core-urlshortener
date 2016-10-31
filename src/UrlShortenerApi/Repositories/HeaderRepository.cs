using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlShortenerApi.Models;
using UrlShortenerApi.Data;

namespace UrlShortenerApi.Repositories
{
    public class HeaderRepository : IHeaderRepository
    {
        ApplicationDbContext _context;
        public HeaderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Microsoft.AspNetCore.Http.IHeaderDictionary headers, System.Guid urlId)
        {
            Header headerItem = new Header();
            Microsoft.Extensions.Primitives.StringValues values;

            // Get User Agent
            headers.TryGetValue("User-Agent", out values);
            if (values.Count > 0)
            {
                headerItem.UserAgent = values.First();
            }

            headerItem.CreationDate = DateTime.Now;
            headerItem.UrlId = urlId;
            Add(headerItem);
        }

        public void Add(Header item)
        {
            _context.Headers.Add(item);
            _context.SaveChanges();
        }
    }
}
