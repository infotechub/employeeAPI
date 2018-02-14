using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class TimeSheetController : Controller
    {
        // GET: TimeSheet
        public ActionResult Index()
        {
            IEnumerable<TimeSheetModel> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("TimeSheet").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<TimeSheetModel>>().Result;
            return View(empList);
        }
    }
}