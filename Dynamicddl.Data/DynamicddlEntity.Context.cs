﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dynamicddl.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DynamicddlEntities : DbContext
    {
        public DynamicddlEntities()
            : base("name=DynamicddlEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblCity> tblCities { get; set; }
        public virtual DbSet<tblEmployee> tblEmployees { get; set; }
        public virtual DbSet<tblState> tblStates { get; set; }
    }
}
