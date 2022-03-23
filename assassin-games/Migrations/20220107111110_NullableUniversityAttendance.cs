using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace assassingames_backend.Migrations
{
    public partial class NullableUniversityAttendance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participations_UniversityAttendances_UniversityAttendanceId",
                table: "Participations");

            migrationBuilder.AlterColumn<Guid>(
                name: "UniversityAttendanceId",
                table: "Participations",
                type: "binary(16)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "binary(16)");

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_UniversityAttendances_UniversityAttendanceId",
                table: "Participations",
                column: "UniversityAttendanceId",
                principalTable: "UniversityAttendances",
                principalColumn: "UniversityAttendanceId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participations_UniversityAttendances_UniversityAttendanceId",
                table: "Participations");

            migrationBuilder.AlterColumn<Guid>(
                name: "UniversityAttendanceId",
                table: "Participations",
                type: "binary(16)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "binary(16)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_UniversityAttendances_UniversityAttendanceId",
                table: "Participations",
                column: "UniversityAttendanceId",
                principalTable: "UniversityAttendances",
                principalColumn: "UniversityAttendanceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
