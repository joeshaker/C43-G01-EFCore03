﻿// <auto-generated />
using System;
using EntityAss3.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityAss3.Migrations
{
    [DbContext(typeof(UpdateItiDbContext))]
    partial class UpdateItiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityAss3.Models.NewCourse", b =>
                {
                    b.Property<int>("Crs_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Crs_Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("CourseName");

                    b.Property<int?>("Top_Id")
                        .HasColumnType("int");

                    b.HasKey("Crs_Id");

                    b.HasIndex("Top_Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Crs_Id = 3,
                            Duration = 0,
                            Name = "Python",
                            Top_Id = 2
                        });
                });

            modelBuilder.Entity("EntityAss3.Models.NewCourse_Inst", b =>
                {
                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.Property<int>("Ins_Id")
                        .HasColumnType("int");

                    b.Property<string>("Evaluate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Course_Id", "Ins_Id");

                    b.HasIndex("Ins_Id");

                    b.ToTable("Course_Ins");
                });

            modelBuilder.Entity("EntityAss3.Models.NewDepartment", b =>
                {
                    b.Property<int>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptId"), 10L, 10);

                    b.Property<DateTime>("Hiring_Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ins_Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("DeptName");

                    b.HasKey("DeptId");

                    b.HasIndex("Ins_Id")
                        .IsUnique()
                        .HasFilter("[Ins_Id] IS NOT NULL");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DeptId = 30,
                            Hiring_Date = new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Ins_Id = 2,
                            Name = "HR"
                        });
                });

            modelBuilder.Entity("EntityAss3.Models.NewInstructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Bouns")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Dept_Id")
                        .HasColumnType("int");

                    b.Property<int>("Hour_Rate")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("Ins_Name");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("Ins_Salary");

                    b.HasKey("Id");

                    b.HasIndex("Dept_Id");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Bouns = 0m,
                            Dept_Id = 20,
                            Hour_Rate = 8,
                            Name = "Rodina",
                            Salary = 8000m
                        });
                });

            modelBuilder.Entity("EntityAss3.Models.NewStd_Course", b =>
                {
                    b.Property<int>("Std_Id")
                        .HasColumnType("int");

                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.HasKey("Std_Id", "Course_Id");

                    b.HasIndex("Course_Id");

                    b.ToTable("Std_Courses");
                });

            modelBuilder.Entity("EntityAss3.Models.NewStudent", b =>
                {
                    b.Property<int>("StdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StdId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("Dep_Id")
                        .HasColumnType("int");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("FirstName");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("LastName");

                    b.HasKey("StdId");

                    b.HasIndex("Dep_Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StdId = 3,
                            Age = 23,
                            Dep_Id = 20,
                            Fname = "Youssef",
                            Lname = "Shaker"
                        });
                });

            modelBuilder.Entity("EntityAss3.Models.NewTopic", b =>
                {
                    b.Property<int>("TopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TopicId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(40)")
                        .HasColumnName("TopicName");

                    b.HasKey("TopicId");

                    b.ToTable("Topics");

                    b.HasData(
                        new
                        {
                            TopicId = 3,
                            Name = "Math"
                        });
                });

            modelBuilder.Entity("EntityAss3.Models.NewCourse", b =>
                {
                    b.HasOne("EntityAss3.Models.NewTopic", "CrsTopic")
                        .WithMany("Courses")
                        .HasForeignKey("Top_Id");

                    b.Navigation("CrsTopic");
                });

            modelBuilder.Entity("EntityAss3.Models.NewCourse_Inst", b =>
                {
                    b.HasOne("EntityAss3.Models.NewCourse", "NewCourse")
                        .WithMany("NewCourse_Insts")
                        .HasForeignKey("Course_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("EntityAss3.Models.NewInstructor", "NewInstructor")
                        .WithMany("NewCourse_Insts")
                        .HasForeignKey("Ins_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("NewCourse");

                    b.Navigation("NewInstructor");
                });

            modelBuilder.Entity("EntityAss3.Models.NewDepartment", b =>
                {
                    b.HasOne("EntityAss3.Models.NewInstructor", "Manager")
                        .WithOne("ManagedDepartment")
                        .HasForeignKey("EntityAss3.Models.NewDepartment", "Ins_Id")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("EntityAss3.Models.NewInstructor", b =>
                {
                    b.HasOne("EntityAss3.Models.NewDepartment", "InsDepartment")
                        .WithMany("Instructors")
                        .HasForeignKey("Dept_Id")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("InsDepartment");
                });

            modelBuilder.Entity("EntityAss3.Models.NewStd_Course", b =>
                {
                    b.HasOne("EntityAss3.Models.NewCourse", "Course")
                        .WithMany("Std_Courses")
                        .HasForeignKey("Course_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("EntityAss3.Models.NewStudent", "Student")
                        .WithMany("Std_Courses")
                        .HasForeignKey("Std_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EntityAss3.Models.NewStudent", b =>
                {
                    b.HasOne("EntityAss3.Models.NewDepartment", "StdDepartment")
                        .WithMany("Students")
                        .HasForeignKey("Dep_Id");

                    b.Navigation("StdDepartment");
                });

            modelBuilder.Entity("EntityAss3.Models.NewCourse", b =>
                {
                    b.Navigation("NewCourse_Insts");

                    b.Navigation("Std_Courses");
                });

            modelBuilder.Entity("EntityAss3.Models.NewDepartment", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("EntityAss3.Models.NewInstructor", b =>
                {
                    b.Navigation("ManagedDepartment");

                    b.Navigation("NewCourse_Insts");
                });

            modelBuilder.Entity("EntityAss3.Models.NewStudent", b =>
                {
                    b.Navigation("Std_Courses");
                });

            modelBuilder.Entity("EntityAss3.Models.NewTopic", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
