﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieTicketbookingModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Vaibhav_test_dbEntities : DbContext
    {
        public Vaibhav_test_dbEntities()
            : base("name=Vaibhav_test_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Movie> Movies1 { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Booking> Bookings1 { get; set; }
    }
}
