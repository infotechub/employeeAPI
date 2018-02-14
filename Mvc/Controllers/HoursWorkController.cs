using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class HoursWorkController : Controller
    {
        // GET: HoursWork
        public ActionResult Index()
        {
            IEnumerable<HoursWorkModel> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("HoursWork").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<HoursWorkModel>>().Result;
            return View(empList);
        }
    }
}