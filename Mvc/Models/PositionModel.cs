using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public class PositionModel
    {
        public int EmployeeId { get; set; }
        public string Title { get; set; }
        public string JobLevel { get; set; }
        public string SkillCategory { get; set; }
        public string Department { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}