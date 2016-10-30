﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace UrlShortenerApi.Models
{
    public class Url
    {
        public int ID { get; set; }
        public string LongFormat { get; set; }
        public string ShortFormat { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatedByIp { get; set; }

        [JsonIgnore]
        public ICollection<Header> Headers { get; set; }
    }
}
