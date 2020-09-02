using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMN.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    NidProject = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TidProject = table.Column<string>(maxLength: 80, nullable: true),
                    DesProject = table.Column<string>(maxLength: 240, nullable: true),
                    DatProjectStart = table.Column<DateTime>(nullable: false),
                    DatProjectEnd = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.NidProject);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTasks",
                columns: table => new
                {
                    NidTask = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NidProject = table.Column<int>(nullable: false),
                    TidTask = table.Column<string>(maxLength: 140, nullable: true),
                    DesTask = table.Column<string>(nullable: true),
                    TimExpected = table.Column<TimeSpan>(nullable: false),
                    TimSpent = table.Column<TimeSpan>(nullable: false),
                    FlgTaskDone = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTasks", x => x.NidTask);
                    table.ForeignKey(
                        name: "FK_ProjectTasks_Projects_NidProject",
                        column: x => x.NidProject,
                        principalTable: "Projects",
                        principalColumn: "NidProject",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTasks_NidProject",
                table: "ProjectTasks",
                column: "NidProject");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectTasks");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
