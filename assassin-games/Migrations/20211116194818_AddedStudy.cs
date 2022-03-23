using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace assassingames_backend.Migrations
{
    public partial class AddedStudy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Campus",
                table: "Participations");

            migrationBuilder.RenameColumn(
                name: "Study",
                table: "Participations",
                newName: "Obituary");

            migrationBuilder.AddColumn<byte[]>(
                name: "StudyId",
                table: "Participations",
                type: "varbinary(16)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.CreateTable(
                name: "Studies",
                columns: table => new
                {
                    StudyId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    StudyName = table.Column<string>(type: "text", nullable: true),
                    Campus = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studies", x => x.StudyId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Participations_StudyId",
                table: "Participations",
                column: "StudyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_Studies_StudyId",
                table: "Participations",
                column: "StudyId",
                principalTable: "Studies",
                principalColumn: "StudyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Studies_StudyId",
                table: "Participations");

            migrationBuilder.DropTable(
                name: "Studies");

            migrationBuilder.DropIndex(
                name: "IX_Participations_StudyId",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "StudyId",
                table: "Participations");

            migrationBuilder.RenameColumn(
                name: "Obituary",
                table: "Participations",
                newName: "Study");

            migrationBuilder.AddColumn<string>(
                name: "Campus",
                table: "Participations",
                type: "text",
                nullable: true);
        }
    }
}
