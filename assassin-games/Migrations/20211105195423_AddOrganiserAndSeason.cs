using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace assassingames_backend.Migrations
{
    public partial class AddOrganiserAndSeason : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organisers",
                columns: table => new
                {
                    OrganiserId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    County = table.Column<string>(type: "text", nullable: true),
                    Municipality = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisers", x => x.OrganiserId);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    SeasonId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    SeasonNumber = table.Column<int>(type: "int", nullable: false),
                    SeasonStart = table.Column<DateTime>(type: "datetime", nullable: false),
                    SeasonEnd = table.Column<DateTime>(type: "datetime", nullable: false),
                    OrganiserId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    RegistrationStart = table.Column<DateTime>(type: "datetime", nullable: false),
                    RegistrationEnd = table.Column<DateTime>(type: "datetime", nullable: false),
                    Phase = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.SeasonId);
                    table.ForeignKey(
                        name: "FK_Seasons_Organisers_OrganiserId",
                        column: x => x.OrganiserId,
                        principalTable: "Organisers",
                        principalColumn: "OrganiserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_OrganiserId",
                table: "Seasons",
                column: "OrganiserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "Organisers");
        }
    }
}
