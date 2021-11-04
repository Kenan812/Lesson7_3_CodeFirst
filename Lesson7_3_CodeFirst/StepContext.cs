using Lesson7_3_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7_3_CodeFirst
{
    public class StepContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Mark> Marks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Step; Integrated Security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne<Mark>(s => s.Mark)
                .WithOne(s => s.Student)
                .HasForeignKey<Mark>(s => s.Id);

            modelBuilder.Entity<Mark>()
                .HasOne<Student>(s => s.Student)
                .WithOne(s => s.Mark)
                .HasForeignKey<Student>(s => s.Id);
        }
    }
}
