using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportShirts.Models;

namespace SportShirts.Backend.Controllers
{
    [Route("api/[controller]")]
    public class ShirtsController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Shirt> Get()
        {
            return new List<Shirt>{new Shirt{}};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Shirt Get(int id)
        {
            return new Shirt{};
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Shirt value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Shirt value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
