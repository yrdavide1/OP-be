using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OP_beContext.Migrations
{
    public partial class AddedUsernamePassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Persons",
                newName: "Username");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Persons",
                newName: "FullName");
        }
    }
}
