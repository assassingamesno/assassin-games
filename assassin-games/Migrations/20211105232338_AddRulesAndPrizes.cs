using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace assassingames_backend.Migrations
{
    public partial class AddRulesAndPrizes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prizes",
                columns: table => new
                {
                    PrizeId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    PrizeDescription = table.Column<string>(type: "text", nullable: true),
                    TaskDescription = table.Column<string>(type: "text", nullable: true),
                    Provider = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false),
                    SeasonId = table.Column<byte[]>(type: "varbinary(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prizes", x => x.PrizeId);
                    table.ForeignKey(
                        name: "FK_Prizes_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rules",
                columns: table => new
                {
                    RuleId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Phase = table.Column<int>(type: "int", nullable: false),
                    Added = table.Column<DateTime>(type: "datetime", nullable: false),
                    SeasonId = table.Column<byte[]>(type: "varbinary(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.RuleId);
                    table.ForeignKey(
                        name: "FK_Rules_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prizes_SeasonId",
                table: "Prizes",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Rules_SeasonId",
                table: "Rules",
                column: "SeasonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prizes");

            migrationBuilder.DropTable(
                name: "Rules");
        }
    }
}
