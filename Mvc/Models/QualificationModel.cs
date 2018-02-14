using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public class QualificationModel
    {
        public int EmployeeId { get; set; }
        public string Department { get; set; }
        public string Qualifications { get; set; }
        public Nullable<int> HourlyRate { get; set; }
    }
}