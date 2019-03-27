using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Schaaktoernooi.Migrations
{
    public partial class addList_of_Sponsor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "List_Of_Sponsors",
                columns: table => new
                {
                    sponsorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SponsorName = table.Column<string>(nullable: true),
                    SponsorPhone = table.Column<string>(nullable: true),
                    OtherSponsorDetails = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_List_Of_Sponsors", x => x.sponsorID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "List_Of_Sponsors");
        }
    }
}
