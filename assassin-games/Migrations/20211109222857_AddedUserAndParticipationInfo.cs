using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace assassingames_backend.Migrations
{
    public partial class AddedUserAndParticipationInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InstagramHandle",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SeasonStart",
                table: "Seasons",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SeasonEnd",
                table: "Seasons",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationStart",
                table: "Seasons",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationEnd",
                table: "Seasons",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Animal",
                table: "Participations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Colour",
                table: "Participations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FeePaid",
                table: "Participations",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Food",
                table: "Participations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Skill",
                table: "Participations",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InstagramHandle",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Animal",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "Colour",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "FeePaid",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "Food",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "Skill",
                table: "Participations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SeasonStart",
                table: "Seasons",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SeasonEnd",
                table: "Seasons",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationStart",
                table: "Seasons",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationEnd",
                table: "Seasons",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");
        }
    }
}
