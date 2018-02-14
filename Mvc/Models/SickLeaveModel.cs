using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public class SickLeaveModel
    {
        public int EmployeeId { get; set; }
        public Nullable<int> TotalSickLeave { get; set; }
        public Nullable<int> Used { get; set; }
        public Nullable<int> Pending { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}