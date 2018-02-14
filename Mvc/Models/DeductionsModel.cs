using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public class DeductionsModel
    {
        public int EmployeeId { get; set; }
        public Nullable<int> Bonus { get; set; }
        public Nullable<int> Tax { get; set; }
        public Nullable<int> Deductions { get; set; }
        public Nullable<int> Total { get; set; }
    }
}