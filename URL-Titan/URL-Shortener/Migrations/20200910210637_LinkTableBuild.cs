using Microsoft.EntityFrameworkCore.Migrations;

namespace URL_Shortener.Migrations
{
    public partial class LinkTableBuild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AddColumn<bool>(
                name: "HasAdminPrivileges",
                table: "UserSet",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "UrlUsersSet",
                columns: table => new
                {
                    UrlId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrlUsersSet", x => new { x.UrlId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UrlUsersSet_UrlSet_UrlId",
                        column: x => x.UrlId,
                        principalTable: "UrlSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UrlUsersSet_UserSet_UserId",
                        column: x => x.UserId,
                        principalTable: "UserSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UrlUsersSet_UserId",
                table: "UrlUsersSet",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UrlUsersSet");

            migrationBuilder.DropColumn(
                name: "HasAdminPrivileges",
                table: "UserSet");

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

        }
    }
}
