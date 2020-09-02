using Microsoft.EntityFrameworkCore.Migrations;

namespace URL_Shortener.Migrations
{
    public partial class addedNavigationProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_UrlSet_URLId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_URLId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "URLId",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "UrlEntityId",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UrlFK",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_User_UrlEntityId",
                table: "User",
                column: "UrlEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_UrlSet_UrlEntityId",
                table: "User",
                column: "UrlEntityId",
                principalTable: "UrlSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_UrlSet_UrlEntityId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_UrlEntityId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UrlEntityId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UrlFK",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "URLId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_URLId",
                table: "User",
                column: "URLId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_UrlSet_URLId",
                table: "User",
                column: "URLId",
                principalTable: "UrlSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
