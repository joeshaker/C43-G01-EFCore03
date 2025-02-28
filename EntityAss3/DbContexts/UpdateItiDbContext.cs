using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityAss3.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityAss3.DbContexts
{
    internal class UpdateItiDbContext : DbContext
    {
        public UpdateItiDbContext() : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database= UpdateItiDb; Trusted_Connection= true; TrustServerCertificate=true")
                .UseLazyLoadingProxies();
        }
        public DbSet<NewStudent> Students { get; set; }
        public DbSet<NewCourse> Courses { get; set; }

        public DbSet<NewDepartment> Departments { get; set; }

        public DbSet<NewStd_Course> Std_Courses { get; set; }
        public DbSet<NewInstructor> Instructors { get; set; }
        public DbSet<NewTopic> Topics { get; set; }
        public DbSet<NewCourse_Inst> Course_Insts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ModelsConf.Student_Crs_Conf());
            modelBuilder.ApplyConfiguration(new ModelsConf.Crs_Ins_Conf());
            modelBuilder.ApplyConfiguration(new ModelsConf.InstructorConf());
            modelBuilder.Entity<NewDepartment>()
                .Property(d => d.DeptId).UseIdentityColumn(10, 10);
            #region Date Seed Migration
            //modelBuilder.Entity<NewStudent>().HasData(new NewStudent { StdId = 3, Fname = "Youssef", Lname = "Shaker", Age = 23, Dep_Id = 20 });
            //modelBuilder.Entity<NewDepartment>().HasData(new NewDepartment { DeptId = 30, Name = "HR", Hiring_Date = new DateTime(2024, 5, 12),Ins_Id=2 });
            //modelBuilder.Entity<NewCourse>().HasData(new NewCourse { Crs_Id = 3, Name = "Python", Top_Id = 2 });
            //modelBuilder.Entity<NewTopic>().HasData(new NewTopic { TopicId = 3, Name = "Math" });
            //modelBuilder.Entity<NewInstructor>().HasData(new NewInstructor { Id = 3, Name = "Rodina", Dept_Id = 20, Hour_Rate = 8, Salary = 8000 });
            #endregion


        }
    }
}
