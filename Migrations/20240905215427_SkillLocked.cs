using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kreshnik.Api.Migrations
{
    /// <inheritdoc />
    public partial class SkillLocked : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ability1",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ability2",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ability3",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Story1",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Story2",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Story3",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Story4",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Story5",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Story6",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Story7",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Story8",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Wounds",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ability1",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Ability2",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Ability3",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Story1",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Story2",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Story3",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Story4",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Story5",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Story6",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Story7",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Story8",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Wounds",
                table: "Heroes");
        }
    }
}
