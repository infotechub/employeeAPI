﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProNinaEntities : DbContext
    {
        public ProNinaEntities()
            : base("name=ProNinaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<BreakTime> BreakTimes { get; set; }
        public virtual DbSet<Deduction> Deductions { get; set; }
        public virtual DbSet<HoursWork> HoursWorks { get; set; }
        public virtual DbSet<LoginStatu> LoginStatus { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<PayRoll> PayRolls { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<SickLeave> SickLeaves { get; set; }
        public virtual DbSet<TimeSheet> TimeSheets { get; set; }
        public virtual DbSet<Vacation> Vacations { get; set; }
        public virtual DbSet<Worksite> Worksites { get; set; }
    }
}
