﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArrayEFProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities(string connectionString)
			: base(connectionString)
        {
        }
   
        public virtual DbSet<input_arrays> input_arrays { get; set; }
        public virtual DbSet<sorted_arrays> sorted_arrays { get; set; }
    }
}