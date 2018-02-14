using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public class HoursWorkModel
    {
        public int EmployeeId { get; set; }
        public Nullable<int> TimeIn { get; set; }
        public Nullable<int> TimeOut { get; set; }
        public Nullable<int> HoursWork1 { get; set; }
        public Nullable<int> HourlyRate { get; set; }
        public Nullable<int> GrossPay { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> Date { get; set; }

    }
}