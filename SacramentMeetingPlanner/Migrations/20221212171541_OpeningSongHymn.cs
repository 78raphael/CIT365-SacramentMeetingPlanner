using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentMeetingPlanner.Migrations
{
    public partial class OpeningSongHymn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HymnsEnum",
                table: "Meeting",
                newName: "OpeningSongHymn");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OpeningSongHymn",
                table: "Meeting",
                newName: "HymnsEnum");
        }
    }
}
