using System.Collections.Generic;
using UrlShortenerApi.Models;

namespace UrlShortenerApi.Repositories
{
    public interface IUrlRepository
    {
        void Add(Url item);
        IEnumerable<Url> GetAll();
        Url Find(int id);
        void Remove(int id);
        void Update(Url item);
    }
}
