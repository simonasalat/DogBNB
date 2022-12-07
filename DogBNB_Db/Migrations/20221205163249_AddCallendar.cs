using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DogBNB_Db.Migrations
{
    public partial class AddCallendar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Callendars",
                columns: table => new
                {
                    CallendarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BookedDayStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookedDayEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Callendars", x => x.CallendarId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Callendars");
        }
    }
}
