using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kreshnik.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdToHero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Heroes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Heroes");
        }
    }
}
