using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class FixedMakeAndModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Make_MakeId",
                schema: "Vehicles",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Make",
                table: "Make");

            migrationBuilder.RenameTable(
                name: "VehicleModel",
                newName: "VehicleModel",
                newSchema: "Vehicles");

            migrationBuilder.RenameTable(
                name: "Make",
                newName: "Manucturer",
                newSchema: "Vehicles");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Vehicles",
                table: "VehicleModel",
                type: "VARCHAR(80)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Vehicles",
                table: "Manucturer",
                type: "VARCHAR(80)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "VehicleModel",
                schema: "Vehicles",
                newName: "VehicleModel");

            migrationBuilder.RenameTable(
                name: "Manucturer",
                schema: "Vehicles",
                newName: "Make");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "VehicleModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Make",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Make",
                table: "Make",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Make_MakeId",
                schema: "Vehicles",
                table: "Vehicle",
                column: "MakeId",
                principalTable: "Make",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
