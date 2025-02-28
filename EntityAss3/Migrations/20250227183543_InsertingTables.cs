using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityAss3.Migrations
{
    /// <inheritdoc />
    public partial class InsertingTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Crs_Id", "Description", "Duration", "CourseName", "Top_Id" },
                values: new object[] { 3, null, 0, "Python", 2 });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DeptId", "Hiring_Date", "Ins_Id", "DeptName" },
                values: new object[] { 30, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "HR" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Address", "Bouns", "Dept_Id", "Hour_Rate", "Ins_Name", "Ins_Salary" },
                values: new object[] { 3, null, 0m, 20, 8, "Rodina", 8000m });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StdId", "Address", "Age", "Dep_Id", "FirstName", "LastName" },
                values: new object[] { 3, null, 23, 20, "Youssef", "Shaker" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicId", "TopicName" },
                values: new object[] { 3, "Math" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Crs_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StdId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 3);
        }
    }
}
