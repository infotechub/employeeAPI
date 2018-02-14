using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class PayRollController : Controller
    {
        // GET: PayRoll
        public ActionResult Index()
        {
            IEnumerable<PayRollModel> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("PayRoll").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<PayRollModel>>().Result;
            return View(empList);
        }
    }
}