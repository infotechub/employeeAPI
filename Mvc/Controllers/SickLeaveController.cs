using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class SickLeaveController : Controller
    {
        // GET: SickLeave
        public ActionResult Index()
        {
            IEnumerable<SickLeaveModel> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("SickLeave").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<SickLeaveModel>>().Result;
            return View(empList);
        }
    }
}