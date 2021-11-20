using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OP_beContext.Migrations
{
    public partial class ChangedPersonStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdministrator",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "IsUser",
                table: "Persons");

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Persons",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Level",
                table: "Persons");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdministrator",
                table: "Persons",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsUser",
                table: "Persons",
                type: "bit",
                nullable: true);
        }
    }
}
