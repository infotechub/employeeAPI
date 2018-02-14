using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class VacationController : Controller
    {
        // GET: Vacation
        public ActionResult Index()
        {
            IEnumerable<VacationModel> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Vacation").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<VacationModel>>().Result;
            return View(empList);
        }
    }
}