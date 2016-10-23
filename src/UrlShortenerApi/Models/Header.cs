using System;

namespace UrlShortenerApi.Models
{
    public class Header
    {
        public int ID { get; set; }
        public string UserAgent { get; set; }
        public string RequestIp { get; set; }
        public int RequestCount { get; set; }
        public DateTime CreationDate { get; set; }
        public int UrlID { get; set; }
        public Url Url { get; set; }
    }
}
