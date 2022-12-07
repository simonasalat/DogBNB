using Microsoft.EntityFrameworkCore.Migrations;

namespace DogBNB_Db.Migrations
{
    public partial class AddSitter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Service_ServiceId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Service",
                table: "Service");

            migrationBuilder.RenameTable(
                name: "Service",
                newName: "Services");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Services",
                table: "Services",
                column: "ServiceId");

            migrationBuilder.CreateTable(
                name: "Sitters",
                columns: table => new
                {
                    SitterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sitters", x => x.SitterId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Services_ServiceId",
                table: "Orders",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "ServiceId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Services_ServiceId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Sitters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Services",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Services");

            migrationBuilder.RenameTable(
                name: "Services",
                newName: "Service");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Service",
                table: "Service",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Service_ServiceId",
                table: "Orders",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "ServiceId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
