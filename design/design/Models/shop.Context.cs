﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace design.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<T_Shop_Admin> T_Shop_Admin { get; set; }
        public virtual DbSet<T_Shop_Basket> T_Shop_Basket { get; set; }
        public virtual DbSet<T_Shop_Buyer> T_Shop_Buyer { get; set; }
        public virtual DbSet<T_Shop_Order> T_Shop_Order { get; set; }
        public virtual DbSet<T_Shop_OrderItems> T_Shop_OrderItems { get; set; }
        public virtual DbSet<T_Shop_Product> T_Shop_Product { get; set; }
        public virtual DbSet<T_Shop_ProductCategory> T_Shop_ProductCategory { get; set; }
    }
}
