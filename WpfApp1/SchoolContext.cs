using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.Data;
using WpfApp1.Entities.Models;

namespace WpfApp1
{
    public class SchoolContext : DbContext   
    {

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //   optionsBuilder.UseSqlServer("Server=localhost;Database=WpfApp1;Trusted_Connection=True;");
        //}
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>()
           .HasKey(t => new { t.StudentId, t.CourseId });

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(st => st.StudentCourse)
                .HasForeignKey(sc => sc.StudentId);
            modelBuilder.Entity<StudentCourse>()
               .HasOne(sc => sc.Course)
               .WithMany(co => co.StudentCourse)
               .HasForeignKey(sc => sc.CourseId);


        }

    }
    }
