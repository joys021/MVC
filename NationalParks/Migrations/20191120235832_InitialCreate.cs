using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParks.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    states = table.Column<string>(nullable: true),
                    latLong = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    designation = table.Column<string>(nullable: true),
                    parkCode = table.Column<string>(nullable: true),
                    id = table.Column<string>(nullable: false),
                    directionsInfo = table.Column<string>(nullable: true),
                    directionsUrl = table.Column<string>(nullable: true),
                    fullName = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true),
                    weatherInfo = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
