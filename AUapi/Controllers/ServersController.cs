using AUdependencies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace AUapi.Controllers
{
    public class ServersController : ApiController
    {

        // GET: api/Servers
        public async Task<IEnumerable<Server>> Get() // work here:
        {
            return null;
        }

        // GET: api/Servers/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Servers
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Servers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Servers/5
        public void Delete(int id)
        {
        }
    }
}
