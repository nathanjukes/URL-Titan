using Microsoft.EntityFrameworkCore.Migrations;

namespace URL_Shortener.Migrations
{
    public partial class addedshortenedID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortenedIdentifier",
                table: "UrlSet",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortenedIdentifier",
                table: "UrlSet");
        }
    }
}
