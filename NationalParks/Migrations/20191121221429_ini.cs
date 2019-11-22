using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParks.Migrations
{
    public partial class ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accessibilityy_RootObject_id",
                table: "Accessibilityy");

            migrationBuilder.DropForeignKey(
                name: "FK_Campsite_RootObject_id",
                table: "Campsite");

            migrationBuilder.DropForeignKey(
                name: "FK_RootObject_Amenity_amenitiesinternetconnectivity",
                table: "RootObject");

            migrationBuilder.DropTable(
                name: "Amenity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RootObject",
                table: "RootObject");

            migrationBuilder.DropIndex(
                name: "IX_RootObject_amenitiesinternetconnectivity",
                table: "RootObject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Campsite",
                table: "Campsite");

            migrationBuilder.DropIndex(
                name: "IX_Campsite_id",
                table: "Campsite");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accessibilityy",
                table: "Accessibilityy");

            migrationBuilder.DropIndex(
                name: "IX_Accessibilityy_id",
                table: "Accessibilityy");

            migrationBuilder.DropColumn(
                name: "amenitiesinternetconnectivity",
                table: "RootObject");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "RootObject",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "parkCode",
                table: "RootObject",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Campsite",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "group",
                table: "Campsite",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Accessibilityy",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cellphoneinfo",
                table: "Accessibilityy",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_RootObject",
                table: "RootObject",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Campsite",
                table: "Campsite",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accessibilityy",
                table: "Accessibilityy",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Accessibilityy_RootObject_id",
                table: "Accessibilityy",
                column: "id",
                principalTable: "RootObject",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Campsite_RootObject_id",
                table: "Campsite",
                column: "id",
                principalTable: "RootObject",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accessibilityy_RootObject_id",
                table: "Accessibilityy");

            migrationBuilder.DropForeignKey(
                name: "FK_Campsite_RootObject_id",
                table: "Campsite");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RootObject",
                table: "RootObject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Campsite",
                table: "Campsite");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accessibilityy",
                table: "Accessibilityy");

            migrationBuilder.AlterColumn<string>(
                name: "parkCode",
                table: "RootObject",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "RootObject",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "amenitiesinternetconnectivity",
                table: "RootObject",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "group",
                table: "Campsite",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Campsite",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "cellphoneinfo",
                table: "Accessibilityy",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Accessibilityy",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_RootObject",
                table: "RootObject",
                column: "parkCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Campsite",
                table: "Campsite",
                column: "group");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accessibilityy",
                table: "Accessibilityy",
                column: "cellphoneinfo");

            migrationBuilder.CreateTable(
                name: "Amenity",
                columns: table => new
                {
                    internetconnectivity = table.Column<string>(nullable: false),
                    amphitheater = table.Column<string>(nullable: true),
                    ampitheater = table.Column<string>(nullable: true),
                    campstore = table.Column<string>(nullable: true),
                    cellphonereception = table.Column<string>(nullable: true),
                    dumpstation = table.Column<string>(nullable: true),
                    firewoodforsale = table.Column<string>(nullable: true),
                    foodstoragelockers = table.Column<string>(nullable: true),
                    iceavailableforsale = table.Column<string>(nullable: true),
                    id = table.Column<string>(nullable: true),
                    laundry = table.Column<string>(nullable: true),
                    stafforvolunteerhostonsite = table.Column<string>(nullable: true),
                    trashrecyclingcollection = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenity", x => x.internetconnectivity);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RootObject_amenitiesinternetconnectivity",
                table: "RootObject",
                column: "amenitiesinternetconnectivity");

            migrationBuilder.CreateIndex(
                name: "IX_Campsite_id",
                table: "Campsite",
                column: "id",
                unique: true,
                filter: "[id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Accessibilityy_id",
                table: "Accessibilityy",
                column: "id",
                unique: true,
                filter: "[id] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Accessibilityy_RootObject_id",
                table: "Accessibilityy",
                column: "id",
                principalTable: "RootObject",
                principalColumn: "parkCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Campsite_RootObject_id",
                table: "Campsite",
                column: "id",
                principalTable: "RootObject",
                principalColumn: "parkCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RootObject_Amenity_amenitiesinternetconnectivity",
                table: "RootObject",
                column: "amenitiesinternetconnectivity",
                principalTable: "Amenity",
                principalColumn: "internetconnectivity",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
