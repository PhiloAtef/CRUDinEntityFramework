﻿using assignment17.Configurations;
using assignment17.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment17.Context
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=DESKTOP-3JOG73P;initial catalog=testing;trusted_connection=true; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Course>(new CourseConfigurations());

            modelBuilder.Entity<Instructor>(E =>
            {
                E.ToTable("Instructors", "dbo");
                E.HasKey(e => e.Id);

                E.Property(e => e.Id)
                    .UseIdentityColumn(10, 10);

                E.Property(e => e.Adress)
                    .HasDefaultValue("Cairo");
            });
            
            
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> courses { get; set; }
    }
}