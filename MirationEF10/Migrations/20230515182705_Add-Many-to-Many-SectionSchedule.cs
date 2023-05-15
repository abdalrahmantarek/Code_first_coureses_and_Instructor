using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MirationEF10.Migrations
{
    /// <inheritdoc />
    public partial class AddManytoManySectionSchedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    SUN = table.Column<bool>(type: "bit", nullable: false),
                    MON = table.Column<bool>(type: "bit", nullable: false),
                    TUS = table.Column<bool>(type: "bit", nullable: false),
                    WEN = table.Column<bool>(type: "bit", nullable: false),
                    THU = table.Column<bool>(type: "bit", nullable: false),
                    FRI = table.Column<bool>(type: "bit", nullable: false),
                    SAT = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectionSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionSchedules_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectionSchedules_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "FRI", "MON", "SAT", "SUN", "THU", "TUS", "Title", "WEN" },
                values: new object[,]
                {
                    { 1, true, false, true, true, true, true, "Daily", true },
                    { 2, true, true, true, false, true, true, "Daily", true },
                    { 3, true, true, false, true, true, true, "Daily", false },
                    { 4, true, true, true, true, true, false, "Daily", true },
                    { 5, false, true, true, true, true, true, "Daily", true }
                });

            migrationBuilder.InsertData(
                table: "SectionSchedules",
                columns: new[] { "Id", "EndTime", "ScheduleId", "SectionId", "StartTime" },
                values: new object[] { 1, new TimeSpan(0, 10, 0, 0, 0), 1, 1, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.CreateIndex(
                name: "IX_SectionSchedules_ScheduleId",
                table: "SectionSchedules",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionSchedules_SectionId",
                table: "SectionSchedules",
                column: "SectionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SectionSchedules");

            migrationBuilder.DropTable(
                name: "Schedules");
        }
    }
}
