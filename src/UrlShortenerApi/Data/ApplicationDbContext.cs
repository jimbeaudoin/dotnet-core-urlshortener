using UrlShortenerApi.Models;
using Microsoft.EntityFrameworkCore;

namespace UrlShortenerApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Url> Urls { get; set; }
        public DbSet<Header> Headers { get; set; }
    }
}
