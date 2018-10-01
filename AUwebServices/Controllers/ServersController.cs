using AUdependencies.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AUwebServices.Controllers
{
    public class ServersController : Controller
    {
        private HttpClient client = new HttpClient();

        private string APIpath = Properties.Settings.Default.API;

        // GET: Servers
        public async Task<ActionResult> Index()
        {
            IEnumerable<Server> servers = null;

            string json = await client.GetStringAsync($"{APIpath}/Servers");

            servers = JsonConvert.DeserializeObject<IEnumerable<Server>>(json);

            return View(servers);
        }

        [HttpGet]
        public ActionResult EditServer(int id)
        {
            return View();
        }
    }
}