using AUdependencies.Context;
using AUdependencies.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace AUapi.Controllers
{
    public class ValuesController : ApiController
    {
        private ApplicationContext db = new ApplicationContext();

        // GET api/values
        public async Task<IEnumerable<Book>> Get()
        {
            IEnumerable<Book> books = await db.Books.ToListAsync();

            return books;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
