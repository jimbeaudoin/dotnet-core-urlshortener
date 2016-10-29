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

        public Url Find(int id)
        {
            return _context.Urls.SingleOrDefault(m => m.ID == id);
        }

        public Url Find(string shortFormat)
        {
            return _context.Urls.SingleOrDefault(m => m.ShortFormat == shortFormat);
        }

        public void Remove(int id)
        {
            var student = _context.Urls.Single(m => m.ID == id);
            if (student != null) 
            {
                _context.Urls.Remove(student);
            } 
        }

        public void Update(Url item)
        {
            _context.Update(item);
        }
    }
}
