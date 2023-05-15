using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MirationEF10.Migrations
{
    /// <inheritdoc />
    public partial class addFnameLname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Instructors",
                newName: "LName");

            migrationBuilder.AddColumn<string>(
                name: "FName",
                table: "Instructors",
                type: "VARCHAR(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FName", "LName" },
                values: new object[] { "Yassmin", "Abdullah" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FName", "LName" },
                values: new object[] { "YassminL", "mohammed" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FName", "LName" },
                values: new object[] { "Khaled", "Ahmed" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FName", "LName" },
                values: new object[] { "Sayed", "Mahros" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FName", "LName" },
                values: new object[] { "Abdo", "Tarek" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FName",
                table: "Instructors");

            migrationBuilder.RenameColumn(
                name: "LName",
                table: "Instructors",
                newName: "Name");

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Yassmin Abdullah");

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Yassmin mohammed");

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Khaled Ahmed");

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Sayed Mahros");

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Abdo Tarek");
        }
    }
}
