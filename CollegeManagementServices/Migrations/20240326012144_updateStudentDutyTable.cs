using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CollegeManagementServices.Migrations
{
    /// <inheritdoc />
    public partial class updateStudentDutyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StudentDuties",
                columns: new[] { "Id", "Code", "Description", "Status" },
                values: new object[,]
                {
                    { 1, "AB10", "Attend classes", "In progress" },
                    { 2, "52GB", "Do some tutoring", "In progress" },
                    { 3, "BH23", "Make some friends", "Not started" },
                    { 4, "M2O3", "Score good grades", "Completed" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentDuties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentDuties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentDuties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentDuties",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
