using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace AUwebServices.Controllers
{
    public class HomeController : Controller
    {
        private HttpClient client = new HttpClient();
        private string APIpath = Properties.Settings.Default.API;

        public async Task<ActionResult> Index()
        {
            /*IEnumerable<Book> books = null;

            string json = await client.GetStringAsync($"{APIpath}/values");

            books = JsonConvert.DeserializeObject<IEnumerable<Book>>(json);*/

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}