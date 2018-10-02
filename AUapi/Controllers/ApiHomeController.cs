using System.Web.Mvc;

namespace AUapi.Controllers
{
    public class ApiHomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
