using EntityAss3.DbContexts;
using EntityAss3.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityAss3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            UpdateItiDbContext relationItiDbContext = new UpdateItiDbContext();
            using UpdateItiDbContext dbContext = new UpdateItiDbContext();
            #region Data Seed Manual
            //NewStudent student = new NewStudent()
            //{
            //    //Dep_Id=10,
            //    Fname = "Ali",
            //    Lname = "Ahmed",
            //    Age = 20,
            //    Address = "Cairo"

            //};
            //relationItiDbContext.Set<NewStudent>().Add(student);
            //relationItiDbContext.SaveChanges();
            //NewDepartment newDepartment = new NewDepartment()
            //{
            //    Name = "IT",
            //    Hiring_Date = new DateTime(2022, 3, 5),
            //    //Ins_Id = 1,

            //};
            //relationItiDbContext.Set<NewDepartment>().Add(newDepartment);
            ////relationItiDbContext.SaveChanges();

            //NewInstructor newInstructor = new NewInstructor()
            //{
            //    //Dept_Id = 1,
            //    Name = "Mohamed",
            //    Address = "Giza",
            //    Hour_Rate = 10,
            //    Bouns = 1000,
            //    Salary = 10000
            //};
            //relationItiDbContext.Set<NewInstructor>().Add(newInstructor);
            //relationItiDbContext.SaveChanges();

            //NewCourse newCourse = new NewCourse()
            //{
            //    Name = "C#",
            //    Duration = 10,
            //    //Top_Id = 1,
            //    Description = "C# Course",
            //};
            //relationItiDbContext.Set<NewCourse>().Add(newCourse);


            //NewTopic newTopic = new NewTopic()
            //{
            //    Name = "Programming",

            //};
            //relationItiDbContext.Set<NewTopic>().Add(newTopic);
            //NewCourse_Inst newCourse_Inst = new NewCourse_Inst()
            //{
            //    Course_Id = 2,
            //    Ins_Id = 2,
            //    Evaluate = "Good",
            //};
            //relationItiDbContext.Set<NewCourse_Inst>().Add(newCourse_Inst);
            //NewStd_Course newStd_Course = new NewStd_Course() { Course_Id = 2, Std_Id = 1, Grade = 90 };
            //relationItiDbContext.Set<NewStd_Course>().Add(newStd_Course);
            //relationItiDbContext.SaveChanges();
            #endregion
            #region Insert
            //List<NewStudent> students = new List<NewStudent>
            //{
            //    new NewStudent { Fname = "Ali", Lname = "Ahmed", Age = 20, Address = "Cairo" ,Dep_Id=10},
            //    new NewStudent { Fname = "Omar", Lname = "Mohamed", Age = 22, Address = "Alexandria" ,Dep_Id=10},
            //    new NewStudent { Fname = "Hana", Lname = "Mahmoud", Age = 21, Address = "Giza" , Dep_Id = 20},
            //    new NewStudent { Fname = "Lina", Lname = "Samy", Age = 19, Address = "Cairo" , Dep_Id = 30},
            //    new NewStudent { Fname = "Youssef", Lname = "Ali", Age = 23, Address = "Alexandria" ,Dep_Id=30 }
            //};
            //relationItiDbContext.Set<NewStudent>().AddRange(students);

            //List<NewDepartment> departments = new List<NewDepartment>
            //{
            //    new NewDepartment { Name = "Finance", Hiring_Date = new DateTime(2023, 1, 15),Ins_Id=1 },
            //    new NewDepartment { Name = "Marketing", Hiring_Date = new DateTime(2020, 9, 20) },
            //    new NewDepartment { Name = "Operations", Hiring_Date = new DateTime(2022, 11, 25) ,Ins_Id = 3}
            //};
            //relationItiDbContext.Set<NewDepartment>().AddRange(departments);

            //List<NewInstructor> instructors = new List<NewInstructor>
            //{
            //    new NewInstructor { Name = "Mohamed", Address = "Giza", Hour_Rate = 10, Bouns = 1000, Salary = 10000 ,Dept_Id=80},
            //    new NewInstructor { Name = "Ahmed", Address = "Cairo", Hour_Rate = 15, Bouns = 1200, Salary = 12000 ,Dept_Id=90},
            //    new NewInstructor { Name = "Sara", Address = "Alexandria", Hour_Rate = 12, Bouns = 1100, Salary = 11000 ,Dept_Id=10},
            //    new NewInstructor { Name = "Nadia", Address = "Giza", Hour_Rate = 14, Bouns = 1300, Salary = 13000 ,Dept_Id=10},
            //    new NewInstructor { Name = "Karim", Address = "Cairo", Hour_Rate = 11, Bouns = 1050, Salary = 10500 ,Dept_Id=80}
            //};
            //relationItiDbContext.Set<NewInstructor>().AddRange(instructors);

            //List<NewCourse> courses = new List<NewCourse>
            //{
            //    new NewCourse { Name = "Java", Duration = 15, Description = "Java Course",Top_Id=2 },
            //    new NewCourse { Name = "SQL", Duration = 8, Description = "SQL Course" ,Top_Id=4},
            //    new NewCourse { Name = "JavaScript", Duration = 10, Description = "JavaScript Course",Top_Id = 5 },
            //    new NewCourse { Name = "Dart", Duration = 10, Description = "Dart Course",Top_Id = 6 },
            //    new NewCourse { Name = "C++", Duration = 12, Description = "C++ Course",Top_Id = 2 },
            //    new NewCourse { Name = "Flutter", Duration = 12, Description = "Flutter Course",Top_Id = 6 }
            //};
            //relationItiDbContext.Set<NewCourse>().AddRange(courses);

            //List<NewTopic> topics = new List<NewTopic>
            //{
            //    new NewTopic { Name = "Database" },
            //    new NewTopic { Name = "Web Development" },
            //    new NewTopic { Name = "Mobile Development" },
            //    new NewTopic { Name = "Data Science" }
            //};
            //relationItiDbContext.Set<NewTopic>().AddRange(topics);

            //List<NewCourse_Inst> courseInstructors = new List<NewCourse_Inst>
            //{
            //    new NewCourse_Inst { Course_Id = 3, Ins_Id = 1, Evaluate = "Good" },
            //    new NewCourse_Inst { Course_Id = 2, Ins_Id = 4, Evaluate = "Excellent" },
            //    new NewCourse_Inst { Course_Id = 3, Ins_Id = 3, Evaluate = "Very Good" },
            //    new NewCourse_Inst { Course_Id = 4, Ins_Id = 1, Evaluate = "Good" },
            //    new NewCourse_Inst { Course_Id = 5, Ins_Id = 5, Evaluate = "Excellent" }
            //};
            //relationItiDbContext.Set<NewCourse_Inst>().AddRange(courseInstructors);

            //List<NewStd_Course> studentCourses = new List<NewStd_Course>
            //{
            //    new NewStd_Course { Course_Id = 3, Std_Id = 1, Grade = 90 },
            //    new NewStd_Course { Course_Id = 4, Std_Id = 3, Grade = 85 },
            //    new NewStd_Course { Course_Id = 3, Std_Id = 3, Grade = 88 },
            //    new NewStd_Course { Course_Id = 4, Std_Id = 9, Grade = 92 },
            //    new NewStd_Course { Course_Id = 5, Std_Id = 11, Grade = 87 }
            //};
            //relationItiDbContext.Set<NewStd_Course>().AddRange(studentCourses);

            //relationItiDbContext.SaveChanges(); 
            #endregion
            #region Update Data
            //var std = dbContext.Students.FirstOrDefault(e=>e.StdId==2);
            //Console.WriteLine(std.Fname);
            //std.Fname = "Mohamed";
            //dbContext.SaveChanges();
            //Console.WriteLine("AfterChanging");
            //Console.WriteLine(std.Fname);
            #endregion
            #region Deleting Data
            //var std = dbContext.Students.FirstOrDefault(e => e.StdId == 2);
            //dbContext.Students.Remove(std);
            //dbContext.SaveChanges();
            #endregion
            #region Select Data
            //var std = dbContext.Students.FirstOrDefault(e => e.StdId == 1);
            //Console.WriteLine(std.Fname);
            #endregion
            #region Loading Data With Eager
            //var InstructorsWithDept =dbContext.Instructors.Include(e => e.ManagedDepartment).Where(e=>e.Id==3);
            //if(InstructorsWithDept != null)
            //{
            //    foreach (var item in InstructorsWithDept)
            //    {
            //        Console.WriteLine("Manager name: "+item.Name);
            //        Console.WriteLine("Department Id: "+item.Dept_Id);
            //        Console.WriteLine("Derpartment Name: "+item.ManagedDepartment.Name);
            //    }
            //}
            //var InstructorsWithDept01 = dbContext.Instructors.Include(e => e.InsDepartment).ThenInclude(e=>e.Manager).Where(e => e.Id == 8);
            //if (InstructorsWithDept01 != null)
            //{
            //    foreach (var item in InstructorsWithDept01)
            //    {
            //        Console.WriteLine("Instructor name: " + item.Name);
            //        Console.WriteLine("Department Id: " + item.Dept_Id);
            //        Console.WriteLine("Derpartment Name: " + item.InsDepartment.Name);
            //        Console.WriteLine("Derpartment Manager Id: " + item.InsDepartment?.Ins_Id);
            //        Console.WriteLine("Derpartment Manager Name: " + item.InsDepartment?.Manager?.Name);

            //    }
            //} 
            //var InstructorsWithDept02 = dbContext.Instructors.Include(e => e.InsDepartment).Where(e => e.InsDepartment.Name== "Finance");
            //if (InstructorsWithDept02 != null)
            //{
            //    foreach (var item in InstructorsWithDept02)
            //    {
            //        Console.WriteLine("Instructor name: " + item.Name);
            //        Console.WriteLine("Department Id: " + item.InsDepartment.Name);
            //    }
            //}
            #endregion
            #region Loading Data With Explicit
            //var department = dbContext.Departments.FirstOrDefault(e => e.DeptId == 80);
            //if (department != null)
            //{
            //    Console.WriteLine("Department Name: " + department.Name);
            //}
            //dbContext.Entry(department).Collection(e => e.Instructors).Load();
            //foreach(var item in department.Instructors)
            //{
            //    Console.WriteLine("Instructor Name: " + item.Name);
            //}
            #endregion
            #region Loading Data With Lazy
            //var inst01= dbContext.Instructors.FirstOrDefault(e => e.Id == 8);
            //if (inst01 != null)
            //{
            //    Console.WriteLine("Instructor Name: " + inst01.Name);
            //    Console.WriteLine("Department Id: " + inst01.Dept_Id);
            //    Console.WriteLine("Department Name: " + inst01.InsDepartment?.Name);
            //}
            //var dept0=dbContext.Set<NewDepartment>().FirstOrDefault(e=>e.DeptId==80);
            //if (dept0 != null)
            //{
            //    Console.WriteLine("Department Name: " + dept0.Name);
            //    foreach (var item in dept0.Instructors)
            //    {
            //        Console.WriteLine("Instructor Name: " + item.Name);
            //    }
            //}
            #endregion
        }
    }
}
