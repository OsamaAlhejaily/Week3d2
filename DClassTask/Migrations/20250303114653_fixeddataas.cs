using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DClassTask.Migrations
{
    /// <inheritdoc />
    public partial class fixeddataas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "startDate",
                table: "EmployeeProjects",
                newName: "StartDate");

            migrationBuilder.UpdateData(
                table: "EmployeeProjects",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1, 1 },
                column: "StartDate",
                value: new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "EmployeeProjects",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1, 2 },
                column: "StartDate",
                value: new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "EmployeeProjects",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1, 3 },
                column: "StartDate",
                value: new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "EmployeeProjects",
                newName: "startDate");

            migrationBuilder.UpdateData(
                table: "EmployeeProjects",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1, 1 },
                column: "startDate",
                value: new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "EmployeeProjects",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1, 2 },
                column: "startDate",
                value: new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "EmployeeProjects",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1, 3 },
                column: "startDate",
                value: new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
