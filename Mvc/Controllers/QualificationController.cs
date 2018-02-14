using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class QualificationController : Controller
    {
        // GET: Qualification
        public ActionResult Index()
        {
            IEnumerable<QualificationModel> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Qualification").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<QualificationModel>>().Result;
            return View(empList);
        }
    }
}