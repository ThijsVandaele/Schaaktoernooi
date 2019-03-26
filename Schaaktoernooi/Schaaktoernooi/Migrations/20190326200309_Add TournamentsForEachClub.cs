using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Schaaktoernooi.Migrations
{
    public partial class AddTournamentsForEachClub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Toernooi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TournamentName = table.Column<string>(nullable: true),
                    TournamentStartDate = table.Column<DateTime>(nullable: false),
                    TournamentEndDate = table.Column<DateTime>(nullable: false),
                    TournamentDetails = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toernooi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TournamentsForEachClubs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClubId = table.Column<int>(nullable: false),
                    ToernooiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentsForEachClubs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TournamentsForEachClubs_Club_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TournamentsForEachClubs_Toernooi_ToernooiId",
                        column: x => x.ToernooiId,
                        principalTable: "Toernooi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TournamentsForEachClubs_ClubId",
                table: "TournamentsForEachClubs",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentsForEachClubs_ToernooiId",
                table: "TournamentsForEachClubs",
                column: "ToernooiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TournamentsForEachClubs");

            migrationBuilder.DropTable(
                name: "Club");

            migrationBuilder.DropTable(
                name: "Toernooi");
        }
    }
}
