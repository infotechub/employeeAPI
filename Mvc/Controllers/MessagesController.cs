using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class MessagesController : Controller
    {
        // GET: Messages
        public ActionResult Index()
        {
            IEnumerable<MessagesModel> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Messages").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<MessagesModel>>().Result;
            return View(empList);
        }

        public ActionResult AddOrEdit(int id = 0)
        {
            return View(new MessagesModel());
        }
        [HttpPost]
        public ActionResult AddOrEdit(MessagesModel emp)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Messages", emp).Result;
            return RedirectToAction("Index");
        }
    }
        
        //[HttpPost]
        //public ActionResult AddOrEdit(MessagesModel emp)
        //{
        //    if (emp.EmployeeId == 0)
        //    {
        //        HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Messages", emp).Result;
        //        TempData["SuccessMessage"] = "Saved Successfully";
        //    }
        //    else
        //    {
        //        HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Messages/" + emp.EmployeeId, emp).Result;
        //        TempData["SuccessMessage"] = "Updated Successfully";

        //    }
        //    return RedirectToAction("Index");
        //}

        //public ActionResult Delete(int id)
        //{
        //    HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Messages/" + id.ToString()).Result;
        //    TempData["SuccessMessage"] = "Delete Successfully";
        //    return RedirectToAction("Index");
        //}
    
}