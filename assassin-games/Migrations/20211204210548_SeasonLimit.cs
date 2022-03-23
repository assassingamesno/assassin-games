using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace assassingames_backend.Migrations
{
    public partial class SeasonLimit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leaderships_Users_UserId",
                table: "Leaderships");

            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Users_UserId",
                table: "Participations");

            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Studies_StudyId",
                table: "Participations");

            migrationBuilder.DropForeignKey(
                name: "FK_Seasons_Organisers_OrganiserId",
                table: "Seasons");

            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Seasons_SeasonId",
                table: "Participations");

            migrationBuilder.DropForeignKey(
                name: "FK_Prizes_Seasons_SeasonId",
                table: "Prizes");

            migrationBuilder.DropForeignKey(
                name: "FK_Rules_Seasons_SeasonId",
                table: "Rules");

            migrationBuilder.DropForeignKey(
                name: "FK_Hunts_Participations_AssassinId",
                table: "Hunts");

            migrationBuilder.DropForeignKey(
                name: "FK_Hunts_Participations_TargetId",
                table: "Hunts");

            migrationBuilder.DropForeignKey(
                name: "FK_Leaderships_Organisers_OrganiserId",
                table: "Leaderships");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "InstagramHandle",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "EMail",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Users",
                type: "binary(16)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AlterColumn<string>(
                name: "StudyName",
                table: "Studies",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Campus",
                table: "Studies",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "StudyId",
                table: "Studies",
                type: "binary(16)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AddColumn<string>(
                name: "University",
                table: "Studies",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SeasonStart",
                table: "Seasons",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SeasonEnd",
                table: "Seasons",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationStart",
                table: "Seasons",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationEnd",
                table: "Seasons",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrganiserId",
                table: "Seasons",
                type: "binary(16)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AlterColumn<Guid>(
                name: "SeasonId",
                table: "Seasons",
                type: "binary(16)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AddColumn<int>(
                name: "Limit",
                table: "Seasons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<Guid>(
                name: "SeasonId",
                table: "Rules",
                type: "binary(16)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Rules",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Added",
                table: "Rules",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<Guid>(
                name: "RuleId",
                table: "Rules",
                type: "binary(16)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AlterColumn<string>(
                name: "TaskDescription",
                table: "Prizes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "SeasonId",
                table: "Prizes",
                type: "binary(16)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AlterColumn<string>(
                name: "Provider",
                table: "Prizes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PrizeDescription",
                table: "Prizes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "PrizeId",
                table: "Prizes",
                type: "binary(16)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Participations",
                type: "binary(16)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AlterColumn<Guid>(
                name: "StudyId",
                table: "Participations",
                type: "binary(16)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AlterColumn<string>(
                name: "Stores",
                table: "Participations",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Skill",
                table: "Participations",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "SeasonId",
                table: "Participations",
                type: "binary(16)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AlterColumn<string>(
                name: "Obituary",
                table: "Participations",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nickname",
                table: "Participations",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "HangoutSpots",
                table: "Participations",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Food",
                table: "Participations",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Colour",
                table: "Participations",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Biography",
                table: "Participations",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Animal",
                table: "Participations",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Participations",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "ParticipationId",
                table: "Participations",
                type: "binary(16)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Organisers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Municipality",
                table: "Organisers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "County",
                table: "Organisers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Organisers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrganiserId",
                table: "Organisers",
                type: "binary(16)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Leaderships",
                type: "binary(16)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrganiserId",
                table: "Leaderships",
                type: "binary(16)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LeadershipStart",
                table: "Leaderships",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LeadershipEnd",
                table: "Leaderships",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "LeadershipId",
                table: "Leaderships",
                type: "binary(16)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AlterColumn<Guid>(
                name: "TargetId",
                table: "Hunts",
                type: "binary(16)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "KillTime",
                table: "Hunts",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AssassinId",
                table: "Hunts",
                type: "binary(16)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AlterColumn<Guid>(
                name: "HuntId",
                table: "Hunts",
                type: "binary(16)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_Studies_StudyId",
                table: "Participations",
                column: "StudyId",
                principalTable: "Studies",
                principalColumn: "StudyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seasons_Organisers_OrganiserId",
                table: "Seasons",
                column: "OrganiserId",
                principalTable: "Organisers",
                principalColumn: "OrganiserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_Seasons_SeasonId",
                table: "Participations",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "SeasonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prizes_Seasons_SeasonId",
                table: "Prizes",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "SeasonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rules_Seasons_SeasonId",
                table: "Rules",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "SeasonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hunts_Participations_AssassinId",
                table: "Hunts",
                column: "AssassinId",
                principalTable: "Participations",
                principalColumn: "ParticipationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hunts_Participations_TargetId",
                table: "Hunts",
                column: "TargetId",
                principalTable: "Participations",
                principalColumn: "ParticipationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Leaderships_Organisers_OrganiserId",
                table: "Leaderships",
                column: "OrganiserId",
                principalTable: "Organisers",
                principalColumn: "OrganiserId",
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

            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Studies_StudyId",
                table: "Participations");

            migrationBuilder.DropForeignKey(
                name: "FK_Seasons_Organisers_OrganiserId",
                table: "Seasons");

            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Seasons_SeasonId",
                table: "Participations");

            migrationBuilder.DropForeignKey(
                name: "FK_Prizes_Seasons_SeasonId",
                table: "Prizes");

            migrationBuilder.DropForeignKey(
                name: "FK_Rules_Seasons_SeasonId",
                table: "Rules");

            migrationBuilder.DropForeignKey(
                name: "FK_Hunts_Participations_AssassinId",
                table: "Hunts");

            migrationBuilder.DropForeignKey(
                name: "FK_Hunts_Participations_TargetId",
                table: "Hunts");

            migrationBuilder.DropForeignKey(
                name: "FK_Leaderships_Organisers_OrganiserId",
                table: "Leaderships");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "InstagramHandle",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "EMail",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<byte[]>(
                name: "UserId",
                table: "Users",
                type: "varbinary(16)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "binary(16)");

            migrationBuilder.AlterColumn<string>(
                name: "StudyName",
                table: "Studies",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Campus",
                table: "Studies",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<byte[]>(
                name: "StudyId",
                table: "Studies",
                type: "varbinary(16)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "binary(16)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SeasonStart",
                table: "Seasons",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SeasonEnd",
                table: "Seasons",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationStart",
                table: "Seasons",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationEnd",
                table: "Seasons",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "OrganiserId",
                table: "Seasons",
                type: "varbinary(16)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "binary(16)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "SeasonId",
                table: "Seasons",
                type: "varbinary(16)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "binary(16)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "SeasonId",
                table: "Rules",
                type: "varbinary(16)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "binary(16)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Rules",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Added",
                table: "Rules",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "RuleId",
                table: "Rules",
                type: "varbinary(16)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "binary(16)");

            migrationBuilder.AlterColumn<string>(
                name: "TaskDescription",
                table: "Prizes",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<byte[]>(
                name: "SeasonId",
                table: "Prizes",
                type: "varbinary(16)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "binary(16)");

            migrationBuilder.AlterColumn<string>(
                name: "Provider",
                table: "Prizes",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PrizeDescription",
                table: "Prizes",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<byte[]>(
                name: "PrizeId",
                table: "Prizes",
                type: "varbinary(16)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "binary(16)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "UserId",
                table: "Participations",
                type: "varbinary(16)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "binary(16)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "StudyId",
                table: "Participations",
                type: "varbinary(16)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "binary(16)");

            migrationBuilder.AlterColumn<string>(
                name: "Stores",
                table: "Participations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Skill",
                table: "Participations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<byte[]>(
                name: "SeasonId",
                table: "Participations",
                type: "varbinary(16)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "binary(16)");

            migrationBuilder.AlterColumn<string>(
                name: "Obituary",
                table: "Participations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nickname",
                table: "Participations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "HangoutSpots",
                table: "Participations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Food",
                table: "Participations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Colour",
                table: "Participations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Biography",
                table: "Participations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Animal",
                table: "Participations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Participations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<byte[]>(
                name: "ParticipationId",
                table: "Participations",
                type: "varbinary(16)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "binary(16)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Organisers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Municipality",
                table: "Organisers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "County",
                table: "Organisers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Organisers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<byte[]>(
                name: "OrganiserId",
                table: "Organisers",
                type: "varbinary(16)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "binary(16)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "UserId",
                table: "Leaderships",
                type: "varbinary(16)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "binary(16)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "OrganiserId",
                table: "Leaderships",
                type: "varbinary(16)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "binary(16)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LeadershipStart",
                table: "Leaderships",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LeadershipEnd",
                table: "Leaderships",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "LeadershipId",
                table: "Leaderships",
                type: "varbinary(16)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "binary(16)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "TargetId",
                table: "Hunts",
                type: "varbinary(16)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "binary(16)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "KillTime",
                table: "Hunts",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "AssassinId",
                table: "Hunts",
                type: "varbinary(16)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "binary(16)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "HuntId",
                table: "Hunts",
                type: "varbinary(16)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "binary(16)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_Studies_StudyId",
                table: "Participations",
                column: "StudyId",
                principalTable: "Studies",
                principalColumn: "StudyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seasons_Organisers_OrganiserId",
                table: "Seasons",
                column: "OrganiserId",
                principalTable: "Organisers",
                principalColumn: "OrganiserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_Seasons_SeasonId",
                table: "Participations",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "SeasonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prizes_Seasons_SeasonId",
                table: "Prizes",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "SeasonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rules_Seasons_SeasonId",
                table: "Rules",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "SeasonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hunts_Participations_AssassinId",
                table: "Hunts",
                column: "AssassinId",
                principalTable: "Participations",
                principalColumn: "ParticipationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hunts_Participations_TargetId",
                table: "Hunts",
                column: "TargetId",
                principalTable: "Participations",
                principalColumn: "ParticipationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Leaderships_Organisers_OrganiserId",
                table: "Leaderships",
                column: "OrganiserId",
                principalTable: "Organisers",
                principalColumn: "OrganiserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
