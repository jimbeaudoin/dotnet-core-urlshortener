using System;

namespace UrlShortenerApi.Models
{
    public class Header
    {
        public int Id { get; set; }
        public string UserAgent { get; set; }
        public string RequestIp { get; set; }
        public DateTime CreationDate { get; set; }
        public System.Guid UrlId { get; set; }
        public Url Url { get; set; }
    }
}
