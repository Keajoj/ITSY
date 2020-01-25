using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITSY.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subject = table.Column<string>(nullable: true),
                    priority = table.Column<string>(nullable: true),
                    issueType = table.Column<string>(nullable: true),
                    openDate = table.Column<DateTime>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    worklog = table.Column<string>(nullable: true),
                    open = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");
        }
    }
}
