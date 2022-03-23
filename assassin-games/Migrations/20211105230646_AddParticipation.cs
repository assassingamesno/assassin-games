using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace assassingames_backend.Migrations
{
    public partial class AddParticipation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Participations",
                columns: table => new
                {
                    ParticipationId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    UserId = table.Column<string>(type: "varchar(767)", nullable: true),
                    SeasonId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Study = table.Column<string>(type: "text", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Nickname = table.Column<string>(type: "text", nullable: true),
                    Biography = table.Column<string>(type: "text", nullable: true),
                    HangoutSpots = table.Column<string>(type: "text", nullable: true),
                    Stores = table.Column<string>(type: "text", nullable: true),
                    Campus = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participations", x => x.ParticipationId);
                    table.ForeignKey(
                        name: "FK_Participations_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Participations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Participations_SeasonId",
                table: "Participations",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Participations_UserId",
                table: "Participations",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participations");
        }
    }
}
