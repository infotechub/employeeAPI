using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class WorkSiteController : Controller
    {
        // GET: WorkSite
        public ActionResult Index()
        {
            IEnumerable<WorkSiteModel> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("WorkSite").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<WorkSiteModel>>().Result;
            return View(empList);
        }
    }
}