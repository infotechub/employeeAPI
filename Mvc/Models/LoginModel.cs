using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public partial class LoginModel
    {
        public int EmployeeId { get; set; }
       
        public string IPAddress { get; set; }
        public string Status { get; set; }
        [DisplayName("User Name")]
        [Required(ErrorMessage ="User Name is required!")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required!")]
        public string Password { get; set; }
    }
}