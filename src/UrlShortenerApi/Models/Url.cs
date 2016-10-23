using System;
using System.Collections.Generic;

namespace UrlShortenerApi.Repositories
{
    public class Url
    {
        public int ID { get; set; }
        public string LongFormat { get; set; }
        public string ShortFormat { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatedByIp { get; set; }
        public ICollection<Header> Headers { get; set; }
    }
}
