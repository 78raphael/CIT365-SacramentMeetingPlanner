using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentMeetingPlanner.Migrations
{
    public partial class SacramentHymnChoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClosingSongHymn",
                table: "Meeting",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IntermediateMusicalNumberHymn",
                table: "Meeting",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SacramentHymnChoice",
                table: "Meeting",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClosingSongHymn",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "IntermediateMusicalNumberHymn",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "SacramentHymnChoice",
                table: "Meeting");
        }
    }
}
