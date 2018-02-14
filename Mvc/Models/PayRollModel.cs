using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public class PayRollModel
    {
        public int EmployeeId { get; set; }
        public Nullable<int> TotalWorkHours { get; set; }
        public Nullable<int> HourlyRate { get; set; }
        public Nullable<int> Deductions { get; set; }
        public Nullable<int> NetPay { get; set; }
        public string Month { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DateCompiled { get; set; }
    }
}