using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class DeductionController : Controller
    {
        // GET: Deduction
        public ActionResult Index()
        {
            IEnumerable<DeductionsModel> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Deduction").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<DeductionsModel>>().Result;
            return View(empList);
        }
    }
}