﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SyncSeomcMember
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DW_CRMEntities : DbContext
    {
        public DW_CRMEntities()
            : base("name=DW_CRMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<F_CUST_ACCOUNT_CRM> F_CUST_ACCOUNT_CRM { get; set; }
        public virtual DbSet<F_SP_PROCESS> F_SP_PROCESS { get; set; }
        public virtual DbSet<F_CUST_ACCOUNT_CRM_BD> F_CUST_ACCOUNT_CRM_BD { get; set; }
        public virtual DbSet<F_CUST_ACCOUNT_CRM_BM> F_CUST_ACCOUNT_CRM_BM { get; set; }
    }
}
