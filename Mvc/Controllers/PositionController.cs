using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class PositionController : Controller
    {
        // GET: Position
        public ActionResult Index()
        {
            IEnumerable<PositionModel> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Profile").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<PositionModel>>().Result;
            return View(empList);
        }
    }
}