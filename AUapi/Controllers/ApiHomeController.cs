using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using AUdependencies.Context;
using AUdependencies.Models;

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
