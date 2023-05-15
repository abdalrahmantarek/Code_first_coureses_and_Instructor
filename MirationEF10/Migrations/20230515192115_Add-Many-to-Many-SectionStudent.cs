using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MirationEF10.Migrations
{
    /// <inheritdoc />
    public partial class AddManytoManySectionStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    LName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    FName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectionStudents",
                columns: table => new
                {
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionStudents", x => new { x.SectionId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_SectionStudents_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectionStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FName", "LName" },
                values: new object[,]
                {
                    { 1, "Yassmin", "Abdullah" },
                    { 2, "YassminL", "mohammed" },
                    { 3, "Khaled", "Ahmed" },
                    { 4, "Sayed", "Mahros" },
                    { 5, "Abdo", "Tarek" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SectionStudents_StudentId",
                table: "SectionStudents",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SectionStudents");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
