using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuleCalculatorWeb.Data.Migrations
{
    public partial class addModules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Module",
                columns: table => new
                {
                    moduleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModuleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Credits = table.Column<int>(type: "int", nullable: false),
                    HoursPerWeek = table.Column<int>(type: "int", nullable: false),
                    SelfStudy = table.Column<int>(type: "int", nullable: false),
                    Weeks_in_Semester = table.Column<int>(type: "int", nullable: false),
                    HoursStudyFor = table.Column<int>(type: "int", nullable: false),
                    StudyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReaminingHoursLeft = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.moduleID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Module");
        }
    }
}
