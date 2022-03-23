using Microsoft.EntityFrameworkCore.Migrations;

namespace assassingames_backend.Migrations
{
    public partial class RemoveMyProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Hunts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Hunts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
