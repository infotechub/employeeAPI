using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public class TimeSheetModel
    {
        public int EmployeeId { get; set; }
        public string TotalWorkHours { get; set; }
        public string Totalvacation { get; set; }
        public string TotalBreak { get; set; }
        public string TotalLeave { get; set; }
        public string HourlyRate { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}