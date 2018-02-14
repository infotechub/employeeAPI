using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public class BreakTimeModel
    {
        public int EmployeeId { get; set; }
        public Nullable<int> TotalBreak { get; set; }
        public Nullable<int> Used { get; set; }
        public Nullable<int> Pending { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}