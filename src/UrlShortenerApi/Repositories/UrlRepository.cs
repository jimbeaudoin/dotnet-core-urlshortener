using System;
using System.Collections.Generic;
using System.Linq;
using UrlShortenerApi.Data;
using UrlShortenerApi.Models;

namespace UrlShortenerApi.Repositories
{
    public class UrlRepository : IUrlRepository
    {
        ApplicationDbContext _context;
        public UrlRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Url item)
        {
            item.ShortFormat = UrlShortenerLib.Shortener.GenerateShortFormat(6);
            item.CreationDate = DateTime.Now;
            _context.Urls.Add(item);
            _context.SaveChanges();
        }

        public IEnumerable<Url> GetAll()
        {
            return _context.Urls.ToList();
        }

        public Url Find(System.Guid id)
        {
            return _context.Urls.SingleOrDefault(m => m.Id == id);
        }

        public Url Find(string shortFormat)
        {
            return _context.Urls.SingleOrDefault(m => m.ShortFormat == shortFormat);
        }
    }
}
