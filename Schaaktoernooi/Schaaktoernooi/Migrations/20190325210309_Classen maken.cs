using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Schaaktoernooi.Migrations
{
    public partial class Classenmaken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    ClubID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.ClubID);
                });

            migrationBuilder.CreateTable(
                name: "Toernooi",
                columns: table => new
                {
                    TournamentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TournamentName = table.Column<string>(nullable: true),
                    TournamentStartDate = table.Column<DateTime>(nullable: false),
                    TournamentEndDate = table.Column<DateTime>(nullable: false),
                    TournamentDetails = table.Column<string>(nullable: true),
                    ClubID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toernooi", x => x.TournamentID);
                    table.ForeignKey(
                        name: "FK_Toernooi_Club_ClubID",
                        column: x => x.ClubID,
                        principalTable: "Club",
                        principalColumn: "ClubID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TournamentsForEachClubs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClubID = table.Column<int>(nullable: false),
                    TournamentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentsForEachClubs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TournamentsForEachClubs_Club_ClubID",
                        column: x => x.ClubID,
                        principalTable: "Club",
                        principalColumn: "ClubID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TournamentsForEachClubs_Toernooi_TournamentID",
                        column: x => x.TournamentID,
                        principalTable: "Toernooi",
                        principalColumn: "TournamentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Toernooi_ClubID",
                table: "Toernooi",
                column: "ClubID");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentsForEachClubs_ClubID",
                table: "TournamentsForEachClubs",
                column: "ClubID");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentsForEachClubs_TournamentID",
                table: "TournamentsForEachClubs",
                column: "TournamentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TournamentsForEachClubs");

            migrationBuilder.DropTable(
                name: "Toernooi");

            migrationBuilder.DropTable(
                name: "Club");
        }
    }
}
