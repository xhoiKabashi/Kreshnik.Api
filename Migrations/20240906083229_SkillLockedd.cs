using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kreshnik.Api.Migrations
{
    /// <inheritdoc />
    public partial class SkillLockedd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Story01",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Story02",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Story03",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Story04",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Story05",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Story06",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Story07",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Story08",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Story09",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Story01",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Story02",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Story03",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Story04",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Story05",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Story06",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Story07",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Story08",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Story09",
                table: "Heroes");
        }
    }
}
