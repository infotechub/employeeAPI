using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class BreakTimeController : Controller
    {
        // GET: BreakTime
        public ActionResult Index()
        {
            IEnumerable<BreakTimeModel> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("BreakTime").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<BreakTimeModel>>().Result;
            return View(empList);
        }
    }
}