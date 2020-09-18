using Microsoft.EntityFrameworkCore.Migrations;

namespace URL_Shortener.Migrations
{
    public partial class fixedNullIssue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BaseURL",
                table: "UrlSet",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BaseURL",
                table: "UrlSet",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
