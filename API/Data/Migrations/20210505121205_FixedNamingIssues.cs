using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class FixedNamingIssues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Manucturer_MakeId",
                schema: "Vehicles",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manucturer",
                schema: "Vehicles",
                table: "Manucturer");

            migrationBuilder.RenameTable(
                name: "Manucturer",
                schema: "Vehicles",
                newName: "Manufacturer",
                newSchema: "Vehicles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manufacturer",
                schema: "Vehicles",
                table: "Manufacturer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Manufacturer_MakeId",
                schema: "Vehicles",
                table: "Vehicle",
                column: "MakeId",
                principalSchema: "Vehicles",
                principalTable: "Manufacturer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Manufacturer_MakeId",
                schema: "Vehicles",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manufacturer",
                schema: "Vehicles",
                table: "Manufacturer");

            migrationBuilder.RenameTable(
                name: "Manufacturer",
                schema: "Vehicles",
                newName: "Manucturer",
                newSchema: "Vehicles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manucturer",
                schema: "Vehicles",
                table: "Manucturer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Manucturer_MakeId",
                schema: "Vehicles",
                table: "Vehicle",
                column: "MakeId",
                principalSchema: "Vehicles",
                principalTable: "Manucturer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
