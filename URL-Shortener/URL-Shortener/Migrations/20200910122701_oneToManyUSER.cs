using Microsoft.EntityFrameworkCore.Migrations;

namespace URL_Shortener.Migrations
{
    public partial class oneToManyUSER : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserSet_UrlSet_UrlEntityId",
                table: "UserSet");

            migrationBuilder.DropIndex(
                name: "IX_UserSet_UrlEntityId",
                table: "UserSet");

            migrationBuilder.DropColumn(
                name: "UrlEntityId",
                table: "UserSet");

            migrationBuilder.DropColumn(
                name: "UrlFK",
                table: "UserSet");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UrlSet",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UrlSet_UserId",
                table: "UrlSet",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UrlSet_UserSet_UserId",
                table: "UrlSet",
                column: "UserId",
                principalTable: "UserSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UrlSet_UserSet_UserId",
                table: "UrlSet");

            migrationBuilder.DropIndex(
                name: "IX_UrlSet_UserId",
                table: "UrlSet");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UrlSet");

            migrationBuilder.AddColumn<int>(
                name: "UrlEntityId",
                table: "UserSet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UrlFK",
                table: "UserSet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserSet_UrlEntityId",
                table: "UserSet",
                column: "UrlEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserSet_UrlSet_UrlEntityId",
                table: "UserSet",
                column: "UrlEntityId",
                principalTable: "UrlSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
