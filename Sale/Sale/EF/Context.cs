﻿using System.Data.Entity;
using Sale.Models.Config;
using Sale.Models.Model;

namespace Sale.EF
{
    public class Context : DbContext
    {
        public Context()
            : base("Sales")
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Admin> Admin { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BooksConfigurator());
            modelBuilder.Configurations.Add(new AdminConfigurator());
        }
         
    }
}