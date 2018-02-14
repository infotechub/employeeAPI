using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public class WorkSiteModel
    {
        public int EmployeeId { get; set; }
        public string UserName { get; set; }
        public string Location { get; set; }
        public string Assignment { get; set; }
        public Nullable<System.Guid> Code { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}