﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TortugasKarpenko.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntitiesHome : DbContext
    {
        public EntitiesHome()
            : base("name=EntitiesHome")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Dish> Dish { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Ingridient> Ingridient { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDish> OrderDish { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Table> Table { get; set; }
    }
}
