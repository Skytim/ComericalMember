﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
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
