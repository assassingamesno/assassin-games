using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace assassingames_backend.Migrations
{
    public partial class AddLeadershipAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leaderships",
                columns: table => new
                {
                    LeadershipId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    LeadershipStart = table.Column<DateTime>(type: "datetime", nullable: false),
                    LeadershipEnd = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<string>(type: "varchar(767)", nullable: true),
                    OrganiserId = table.Column<byte[]>(type: "varbinary(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leaderships", x => x.LeadershipId);
                    table.ForeignKey(
                        name: "FK_Leaderships_Organisers_OrganiserId",
                        column: x => x.OrganiserId,
                        principalTable: "Organisers",
                        principalColumn: "OrganiserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Leaderships_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Leaderships_OrganiserId",
                table: "Leaderships",
                column: "OrganiserId");

            migrationBuilder.CreateIndex(
                name: "IX_Leaderships_UserId",
                table: "Leaderships",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leaderships");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
