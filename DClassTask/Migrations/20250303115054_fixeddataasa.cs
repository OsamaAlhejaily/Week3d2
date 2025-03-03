using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DClassTask.Migrations
{
    /// <inheritdoc />
    public partial class fixeddataasa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "performanceRating",
                table: "Employees",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employeeId",
                keyValue: 1,
                column: "performanceRating",
                value: 92.0);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employeeId",
                keyValue: 2,
                column: "performanceRating",
                value: 65.0);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employeeId",
                keyValue: 3,
                column: "performanceRating",
                value: 22.0);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employeeId",
                keyValue: 4,
                column: "performanceRating",
                value: 66.0);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employeeId",
                keyValue: 5,
                column: "performanceRating",
                value: 77.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "performanceRating",
                table: "Employees");
        }
    }
}
