using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kreshnik.Api.Migrations
{
    /// <inheritdoc />
    public partial class expthreashold : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExpThreshold",
                table: "Heroes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpThreshold",
                table: "Heroes");
        }
    }
}
