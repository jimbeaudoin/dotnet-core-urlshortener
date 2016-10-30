using System.Collections.Generic;
using UrlShortenerApi.Models;

namespace UrlShortenerApi.Repositories
{
    public interface IUrlRepository
    {
        void Add(Url item);
        IEnumerable<Url> GetAll();
        Url Find(System.Guid id);
        Url Find(string shortFormat);
        void Remove(System.Guid id);
        void Update(Url item);
    }
}
