﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class lastprakEntities1 : DbContext
    {
        public lastprakEntities1()
            : base("name=lastprakEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<Activity_Event> Activity_Event { get; set; }
        public virtual DbSet<Activity_Topic> Activity_Topic { get; set; }
        public virtual DbSet<Activity_User> Activity_User { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Sex> Sex { get; set; }
        public virtual DbSet<Topic> Topic { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
