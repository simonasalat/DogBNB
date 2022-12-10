using Microsoft.EntityFrameworkCore.Migrations;

namespace DogBNB_Db.Migrations
{
    public partial class AddUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Users_OwnerId1",
                table: "Dogs");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "OwnerId1",
                table: "Dogs",
                newName: "OwnerUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Dogs_OwnerId1",
                table: "Dogs",
                newName: "IX_Dogs_OwnerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Users_OwnerUserId",
                table: "Dogs",
                column: "OwnerUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Users_OwnerUserId",
                table: "Dogs");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OwnerUserId",
                table: "Dogs",
                newName: "OwnerId1");

            migrationBuilder.RenameIndex(
                name: "IX_Dogs_OwnerUserId",
                table: "Dogs",
                newName: "IX_Dogs_OwnerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Users_OwnerId1",
                table: "Dogs",
                column: "OwnerId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
