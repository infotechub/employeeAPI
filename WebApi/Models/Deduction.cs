//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Deduction
    {
        public int EmployeeId { get; set; }
        public Nullable<int> Bonus { get; set; }
        public Nullable<int> Tax { get; set; }
        public Nullable<int> Deductions { get; set; }
        public Nullable<int> Total { get; set; }
    }
}
