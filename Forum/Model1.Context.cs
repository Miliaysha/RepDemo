﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Forum
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ForumEntities1 : DbContext
    {
        public ForumEntities1()
            : base("name=ForumEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Activities> Activities { get; set; }
        public virtual DbSet<Directions> Directions { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Role_info> Role_info { get; set; }
    }
}