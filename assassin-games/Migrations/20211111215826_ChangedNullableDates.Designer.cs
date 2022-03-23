﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using assassingames_backend.DbContexts;

namespace assassingames_backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211111215826_ChangedNullableDates")]
    partial class ChangedNullableDates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("assassingames_backend.Models.Hunt", b =>
                {
                    b.Property<byte[]>("HuntId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("AssassinId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime?>("KillTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<byte[]>("TargetId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.HasKey("HuntId");

                    b.HasIndex("AssassinId");

                    b.HasIndex("TargetId");

                    b.ToTable("Hunts");
                });

            modelBuilder.Entity("assassingames_backend.Models.Leadership", b =>
                {
                    b.Property<byte[]>("LeadershipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime?>("LeadershipEnd")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("LeadershipStart")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("OrganiserId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("UserId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.HasKey("LeadershipId");

                    b.HasIndex("OrganiserId");

                    b.HasIndex("UserId");

                    b.ToTable("Leaderships");
                });

            modelBuilder.Entity("assassingames_backend.Models.Organiser", b =>
                {
                    b.Property<byte[]>("OrganiserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("County")
                        .HasColumnType("text");

                    b.Property<string>("Municipality")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("OrganiserId");

                    b.ToTable("Organisers");
                });

            modelBuilder.Entity("assassingames_backend.Models.Participation", b =>
                {
                    b.Property<byte[]>("ParticipationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Animal")
                        .HasColumnType("text");

                    b.Property<string>("Biography")
                        .HasColumnType("text");

                    b.Property<string>("Campus")
                        .HasColumnType("text");

                    b.Property<string>("Colour")
                        .HasColumnType("text");

                    b.Property<bool>("FeePaid")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Food")
                        .HasColumnType("text");

                    b.Property<string>("HangoutSpots")
                        .HasColumnType("text");

                    b.Property<string>("Nickname")
                        .HasColumnType("text");

                    b.Property<byte[]>("SeasonId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("Skill")
                        .HasColumnType("text");

                    b.Property<string>("Stores")
                        .HasColumnType("text");

                    b.Property<string>("Study")
                        .HasColumnType("text");

                    b.Property<byte[]>("UserId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ParticipationId");

                    b.HasIndex("SeasonId");

                    b.HasIndex("UserId");

                    b.ToTable("Participations");
                });

            modelBuilder.Entity("assassingames_backend.Models.Prize", b =>
                {
                    b.Property<byte[]>("PrizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("PrizeDescription")
                        .HasColumnType("text");

                    b.Property<string>("Provider")
                        .HasColumnType("text");

                    b.Property<byte[]>("SeasonId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("TaskDescription")
                        .HasColumnType("text");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("PrizeId");

                    b.HasIndex("SeasonId");

                    b.ToTable("Prizes");
                });

            modelBuilder.Entity("assassingames_backend.Models.Rule", b =>
                {
                    b.Property<byte[]>("RuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime>("Added")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("Phase")
                        .HasColumnType("int");

                    b.Property<byte[]>("SeasonId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.HasKey("RuleId");

                    b.HasIndex("SeasonId");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("assassingames_backend.Models.Season", b =>
                {
                    b.Property<byte[]>("SeasonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("OrganiserId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<int>("Phase")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistrationEnd")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("RegistrationStart")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("SeasonEnd")
                        .HasColumnType("datetime");

                    b.Property<int>("SeasonNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("SeasonStart")
                        .HasColumnType("datetime");

                    b.HasKey("SeasonId");

                    b.HasIndex("OrganiserId");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("assassingames_backend.Models.User", b =>
                {
                    b.Property<byte[]>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("EMail")
                        .HasColumnType("text");

                    b.Property<string>("InstagramHandle")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("assassingames_backend.Models.Hunt", b =>
                {
                    b.HasOne("assassingames_backend.Models.Participation", "Assassin")
                        .WithMany("Hunts")
                        .HasForeignKey("AssassinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("assassingames_backend.Models.Participation", "Target")
                        .WithMany("Hunteds")
                        .HasForeignKey("TargetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assassin");

                    b.Navigation("Target");
                });

            modelBuilder.Entity("assassingames_backend.Models.Leadership", b =>
                {
                    b.HasOne("assassingames_backend.Models.Organiser", "Organiser")
                        .WithMany("Leaderships")
                        .HasForeignKey("OrganiserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("assassingames_backend.Models.User", "User")
                        .WithMany("Leaderships")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organiser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("assassingames_backend.Models.Participation", b =>
                {
                    b.HasOne("assassingames_backend.Models.Season", "Season")
                        .WithMany("Participations")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("assassingames_backend.Models.User", "User")
                        .WithMany("Participations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Season");

                    b.Navigation("User");
                });

            modelBuilder.Entity("assassingames_backend.Models.Prize", b =>
                {
                    b.HasOne("assassingames_backend.Models.Season", "Season")
                        .WithMany("Prizes")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Season");
                });

            modelBuilder.Entity("assassingames_backend.Models.Rule", b =>
                {
                    b.HasOne("assassingames_backend.Models.Season", "Season")
                        .WithMany("Rules")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Season");
                });

            modelBuilder.Entity("assassingames_backend.Models.Season", b =>
                {
                    b.HasOne("assassingames_backend.Models.Organiser", "Organiser")
                        .WithMany("Seasons")
                        .HasForeignKey("OrganiserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organiser");
                });

            modelBuilder.Entity("assassingames_backend.Models.Organiser", b =>
                {
                    b.Navigation("Leaderships");

                    b.Navigation("Seasons");
                });

            modelBuilder.Entity("assassingames_backend.Models.Participation", b =>
                {
                    b.Navigation("Hunteds");

                    b.Navigation("Hunts");
                });

            modelBuilder.Entity("assassingames_backend.Models.Season", b =>
                {
                    b.Navigation("Participations");

                    b.Navigation("Prizes");

                    b.Navigation("Rules");
                });

            modelBuilder.Entity("assassingames_backend.Models.User", b =>
                {
                    b.Navigation("Leaderships");

                    b.Navigation("Participations");
                });
#pragma warning restore 612, 618
        }
    }
}
