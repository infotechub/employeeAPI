using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public class MessagesModel
    {
        [Required(ErrorMessage = "This Field is Required")]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage="This Field is Required")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Content { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Sender { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Status { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}