using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MirationEF10.Migrations
{
    /// <inheritdoc />
    public partial class AddsectionEntitywithRelationonetoMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    SectionName = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sections_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseName", "Price" },
                values: new object[] { 5, "C++", 2200m });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "CourseId", "InstructorId", "SectionName" },
                values: new object[,]
                {
                    { 1, 1, 1, "S-MA1" },
                    { 2, 1, 2, "S-MA2" },
                    { 3, 2, 3, "S-MA3" },
                    { 4, 2, 2, "S-MA4" },
                    { 5, 3, 3, "S-MA5" },
                    { 6, 3, 5, "S-MA6" },
                    { 7, 4, 4, "S-MA7" },
                    { 8, 4, 4, "S-MA8" },
                    { 9, 5, 2, "S-MA9" },
                    { 10, 5, 1, "S-MA10" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sections_CourseId",
                table: "Sections",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_InstructorId",
                table: "Sections",
                column: "InstructorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
