using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public class VacationModel
    {
        public int EmployeeId { get; set; }
        public Nullable<int> TotalVacation { get; set; }
        public Nullable<int> Used { get; set; }
        public Nullable<int> Pending { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}