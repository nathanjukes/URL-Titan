using Microsoft.EntityFrameworkCore.Migrations;

namespace URL_Shortener.Migrations
{
    public partial class addedIP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExternalIP",
                table: "UrlSet",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExternalIP",
                table: "UrlSet");
        }
    }
}
