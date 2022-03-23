using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace assassingames_backend.Migrations
{
    public partial class AddedUniversityAttendance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Studies_StudyId",
                table: "Participations");

            migrationBuilder.DropIndex(
                name: "IX_Participations_StudyId",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Participations");

            migrationBuilder.RenameColumn(
                name: "StudyId",
                table: "Participations",
                newName: "UniversityAttendanceId");

            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "Studies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Level",
                table: "Studies",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UniversityAttendances",
                columns: table => new
                {
                    UniversityAttendanceId = table.Column<Guid>(type: "binary(16)", nullable: false),
                    StudyId = table.Column<Guid>(type: "binary(16)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityAttendances", x => x.UniversityAttendanceId);
                    table.ForeignKey(
                        name: "FK_UniversityAttendances_Studies_StudyId",
                        column: x => x.StudyId,
                        principalTable: "Studies",
                        principalColumn: "StudyId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Participations_UniversityAttendanceId",
                table: "Participations",
                column: "UniversityAttendanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UniversityAttendances_StudyId",
                table: "UniversityAttendances",
                column: "StudyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_UniversityAttendances_UniversityAttendanceId",
                table: "Participations",
                column: "UniversityAttendanceId",
                principalTable: "UniversityAttendances",
                principalColumn: "UniversityAttendanceId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participations_UniversityAttendances_UniversityAttendanceId",
                table: "Participations");

            migrationBuilder.DropTable(
                name: "UniversityAttendances");

            migrationBuilder.DropIndex(
                name: "IX_Participations_UniversityAttendanceId",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Studies");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Studies");

            migrationBuilder.RenameColumn(
                name: "UniversityAttendanceId",
                table: "Participations",
                newName: "StudyId");

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Participations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
