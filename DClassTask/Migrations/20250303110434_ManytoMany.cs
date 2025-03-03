using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DClassTask.Migrations
{
    /// <inheritdoc />
    public partial class ManytoMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProjects",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProjects", x => new { x.EmployeeId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "employeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "location" },
                values: new object[,]
                {
                    { 1, "Riyadh" },
                    { 2, "Jeddah" },
                    { 3, "Dammam" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Date", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vision 2030 project" },
                    { 2, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "E-Commerce" },
                    { 3, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cloud computing" },
                    { 4, new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cybersecurity" },
                    { 5, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Digital Banking" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "employeeId", "deptId", "employeeName", "salary" },
                values: new object[,]
                {
                    { 1, 1, "Ahmed Al-Qahtani", 12000.0 },
                    { 2, 2, "Khalid Al-Mutairi", 15000.0 },
                    { 3, 3, "Faisal Al-Dosari", 10000.0 },
                    { 4, 1, "Mansour Al-Harbi", 14000.0 },
                    { 5, 2, "Saud Al-Otaibi", 13000.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjects_ProjectId",
                table: "EmployeeProjects",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeProjects");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "employeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "employeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "employeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "employeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "employeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
