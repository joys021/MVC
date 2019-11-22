using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParks.Migrations
{
    public partial class InitialCreattee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Parks",
                table: "Parks");

            migrationBuilder.AlterColumn<string>(
                name: "parkCode",
                table: "Parks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Parks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parks",
                table: "Parks",
                column: "parkCode");

            migrationBuilder.CreateTable(
                name: "Amenity",
                columns: table => new
                {
                    trashrecyclingcollection = table.Column<string>(nullable: true),
                    internetconnectivity = table.Column<string>(nullable: false),
                    id = table.Column<string>(nullable: true),
                    cellphonereception = table.Column<string>(nullable: true),
                    laundry = table.Column<string>(nullable: true),
                    amphitheater = table.Column<string>(nullable: true),
                    dumpstation = table.Column<string>(nullable: true),
                    campstore = table.Column<string>(nullable: true),
                    stafforvolunteerhostonsite = table.Column<string>(nullable: true),
                    iceavailableforsale = table.Column<string>(nullable: true),
                    firewoodforsale = table.Column<string>(nullable: true),
                    ampitheater = table.Column<string>(nullable: true),
                    foodstoragelockers = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenity", x => x.internetconnectivity);
                });

            migrationBuilder.CreateTable(
                name: "RootObject",
                columns: table => new
                {
                    regulationsurl = table.Column<string>(nullable: true),
                    weatheroverview = table.Column<string>(nullable: true),
                    directionsoverview = table.Column<string>(nullable: true),
                    reservationsurl = table.Column<string>(nullable: true),
                    directionsUrl = table.Column<string>(nullable: true),
                    reservationssitesfirstcome = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    regulationsoverview = table.Column<string>(nullable: true),
                    latLong = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    reservationssitesreservable = table.Column<string>(nullable: true),
                    parkCode = table.Column<string>(nullable: false),
                    amenitiesinternetconnectivity = table.Column<string>(nullable: true),
                    id = table.Column<string>(nullable: true),
                    reservationsdescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RootObject", x => x.parkCode);
                    table.ForeignKey(
                        name: "FK_RootObject_Amenity_amenitiesinternetconnectivity",
                        column: x => x.amenitiesinternetconnectivity,
                        principalTable: "Amenity",
                        principalColumn: "internetconnectivity",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Accessibilityy",
                columns: table => new
                {
                    id = table.Column<string>(nullable: true),
                    wheelchairaccess = table.Column<string>(nullable: true),
                    internetinfo = table.Column<string>(nullable: true),
                    rvallowed = table.Column<string>(nullable: true),
                    cellphoneinfo = table.Column<string>(nullable: false),
                    firestovepolicy = table.Column<string>(nullable: true),
                    rvmaxlength = table.Column<string>(nullable: true),
                    additionalinfo = table.Column<string>(nullable: true),
                    trailermaxlength = table.Column<string>(nullable: true),
                    adainfo = table.Column<string>(nullable: true),
                    rvinfo = table.Column<string>(nullable: true),
                    trailerallowed = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accessibilityy", x => x.cellphoneinfo);
                    table.ForeignKey(
                        name: "FK_Accessibilityy_RootObject_id",
                        column: x => x.id,
                        principalTable: "RootObject",
                        principalColumn: "parkCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Campsite",
                columns: table => new
                {
                    id = table.Column<string>(nullable: true),
                    other = table.Column<string>(nullable: true),
                    group = table.Column<string>(nullable: false),
                    horse = table.Column<string>(nullable: true),
                    totalsites = table.Column<string>(nullable: true),
                    tentonly = table.Column<string>(nullable: true),
                    electricalhookups = table.Column<string>(nullable: true),
                    rvonly = table.Column<string>(nullable: true),
                    walkboatto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campsite", x => x.group);
                    table.ForeignKey(
                        name: "FK_Campsite_RootObject_id",
                        column: x => x.id,
                        principalTable: "RootObject",
                        principalColumn: "parkCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accessibilityy_id",
                table: "Accessibilityy",
                column: "id",
                unique: true,
                filter: "[id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Campsite_id",
                table: "Campsite",
                column: "id",
                unique: true,
                filter: "[id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RootObject_amenitiesinternetconnectivity",
                table: "RootObject",
                column: "amenitiesinternetconnectivity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accessibilityy");

            migrationBuilder.DropTable(
                name: "Campsite");

            migrationBuilder.DropTable(
                name: "RootObject");

            migrationBuilder.DropTable(
                name: "Amenity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Parks",
                table: "Parks");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Parks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "parkCode",
                table: "Parks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parks",
                table: "Parks",
                column: "id");
        }
    }
}
