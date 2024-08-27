using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kreshnik.Api.Migrations
{
    /// <inheritdoc />
    public partial class skills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Skill",
                table: "Heroes");

            migrationBuilder.AddColumn<int>(
                name: "HeavyCrashLevel",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MilkRegeLevel",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TearHealLevel",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeavyCrashLevel",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "MilkRegeLevel",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "TearHealLevel",
                table: "Heroes");

            migrationBuilder.AddColumn<string>(
                name: "Skill",
                table: "Heroes",
                type: "TEXT",
                nullable: true);
        }
    }
}
