using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlShortenerApi.Repositories;
using UrlShortenerApi.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace UrlShortenerApi.Controllers
{
    [Route("api/[controller]")]
    public class UrlsController : Controller
    {
        public IUrlRepository Urls { get; set; }
        public UrlsController(IUrlRepository urls)
        {
            Urls = urls;
        }

        // GET: api/urls
        [HttpGet]
        public IEnumerable<Url> GetAll()
        {
            return Urls.GetAll();
        }

        // GET api/urls/dsf034
        [HttpGet("{shortFormat}", Name = "GetUrlByShortFormat")]
        public IActionResult GetByShortFormat(string shortFormat)
        {
            var item = Urls.Find(shortFormat);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        // POST api/urls
        [HttpPost]
        public IActionResult Create([FromBody] Url item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            Urls.Add(item);
            return CreatedAtRoute("GetUrlByShortFormat", new { shortFormat = item.ShortFormat }, item);
        }
    }
}
