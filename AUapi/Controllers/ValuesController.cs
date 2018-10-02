using AUdependencies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace AUapi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public Task<IEnumerable<Server>> Get()
        {
            return null;
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
