using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace assassingames_backend.Migrations
{
    public partial class UpdatedUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leaderships_Users_UserId",
                table: "Leaderships");

            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Users_UserId",
                table: "Participations");

            migrationBuilder.AlterColumn<byte[]>(
                name: "UserId",
                table: "Users",
                type: "varbinary(16)",
                nullable: false,
                defaultValue: "0000000000000000",
                oldClrType: typeof(string),
                oldType: "varchar(767)");

            migrationBuilder.AddColumn<string>(
                name: "EMail",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "UserId",
                table: "Participations",
                type: "varbinary(16)",
                nullable: false,
                defaultValue: "0000000000000000",
                oldClrType: typeof(string),
                oldType: "varchar(767)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "UserId",
                table: "Leaderships",
                type: "varbinary(16)",
                nullable: false,
                defaultValue: "0000000000000000",
                oldClrType: typeof(string),
                oldType: "varchar(767)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Leaderships_Users_UserId",
                table: "Leaderships",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_Users_UserId",
                table: "Participations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leaderships_Users_UserId",
                table: "Leaderships");

            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Users_UserId",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "EMail",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Users",
                type: "varchar(767)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Participations",
                type: "varchar(767)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Leaderships",
                type: "varchar(767)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AddForeignKey(
                name: "FK_Leaderships_Users_UserId",
                table: "Leaderships",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_Users_UserId",
                table: "Participations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
