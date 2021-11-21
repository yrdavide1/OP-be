using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OP_beContext.Migrations
{
    public partial class AddedAdminToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Token",
                table: "Persons");
        }
    }
}
