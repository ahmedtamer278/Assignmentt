using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignmentt.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignmentt.Contex
{
    internal class ItIDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = . ; Database = ITIDb1 ; Trusted_Connection= True; Trust Server Certificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Topic).WithMany(T => T.courses)
                .HasForeignKey(c => c.TopicId)
                .IsRequired(false);

            modelBuilder.Entity<Department>()
                .HasMany(d => d.instructors)
                .WithOne(i => i.WorkDepartment)
                .IsRequired(false)
                .HasForeignKey(i => i.DepartmentId);

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Manager)
                .WithOne(e => e.ManagerDepartment)
                .HasForeignKey<Department>(d => d.ManagerId)
                .IsRequired(false);

            modelBuilder.Entity<Instructor>()
                .Property(i => i.Salary)
                .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Instructor>()
                .Property(i => i.HourRate)
                .HasColumnType("decimal(18,3)");

            

                
                




        }
    }
}
