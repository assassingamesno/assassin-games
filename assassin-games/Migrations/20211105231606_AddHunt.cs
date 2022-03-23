using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace assassingames_backend.Migrations
{
    public partial class AddHunt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hunts",
                columns: table => new
                {
                    HuntId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    MyProperty = table.Column<int>(type: "int", nullable: false),
                    AssassinId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    TargetId = table.Column<byte[]>(type: "varbinary(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hunts", x => x.HuntId);
                    table.ForeignKey(
                        name: "FK_Hunts_Participations_AssassinId",
                        column: x => x.AssassinId,
                        principalTable: "Participations",
                        principalColumn: "ParticipationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hunts_Participations_TargetId",
                        column: x => x.TargetId,
                        principalTable: "Participations",
                        principalColumn: "ParticipationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hunts_AssassinId",
                table: "Hunts",
                column: "AssassinId");

            migrationBuilder.CreateIndex(
                name: "IX_Hunts_TargetId",
                table: "Hunts",
                column: "TargetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hunts");
        }
    }
}
