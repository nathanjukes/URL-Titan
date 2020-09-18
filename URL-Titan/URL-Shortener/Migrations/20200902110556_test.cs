using Microsoft.EntityFrameworkCore.Migrations;

namespace URL_Shortener.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_UrlSet_UrlEntityId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "UserSet");

            migrationBuilder.RenameIndex(
                name: "IX_User_UrlEntityId",
                table: "UserSet",
                newName: "IX_UserSet_UrlEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSet",
                table: "UserSet",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserSet_UrlSet_UrlEntityId",
                table: "UserSet",
                column: "UrlEntityId",
                principalTable: "UrlSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserSet_UrlSet_UrlEntityId",
                table: "UserSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSet",
                table: "UserSet");

            migrationBuilder.RenameTable(
                name: "UserSet",
                newName: "User");

            migrationBuilder.RenameIndex(
                name: "IX_UserSet_UrlEntityId",
                table: "User",
                newName: "IX_User_UrlEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_UrlSet_UrlEntityId",
                table: "User",
                column: "UrlEntityId",
                principalTable: "UrlSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
