﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Schaaktoernooi;

namespace Schaaktoernooi.Migrations
{
    [DbContext(typeof(SchaakContext))]
    [Migration("20190326221427_fix migration error")]
    partial class fixmigrationerror
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Schaaktoernooi.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Club");
                });

            modelBuilder.Entity("Schaaktoernooi.MenuItem", b =>
                {
                    b.Property<int>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Nummer");

                    b.Property<string>("Omschrijving");

                    b.HasKey("MenuID");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("Schaaktoernooi.Toernooi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TournamentDetails");

                    b.Property<DateTime>("TournamentEndDate");

                    b.Property<string>("TournamentName");

                    b.Property<DateTime>("TournamentStartDate");

                    b.HasKey("Id");

                    b.ToTable("Toernooi");
                });

            modelBuilder.Entity("Schaaktoernooi.TournamentsForEachClub", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClubId");

                    b.Property<int>("ToernooiId");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.HasIndex("ToernooiId");

                    b.ToTable("TournamentsForEachClubs");
                });

            modelBuilder.Entity("Schaaktoernooi.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login");

                    b.Property<string>("Paswoord");

                    b.Property<bool>("Type");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Schaaktoernooi.TournamentsForEachClub", b =>
                {
                    b.HasOne("Schaaktoernooi.Club", "Club")
                        .WithMany("TournamentsForEachClubs")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Schaaktoernooi.Toernooi", "Toernooi")
                        .WithMany("TournamentsForEachClubs")
                        .HasForeignKey("ToernooiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
