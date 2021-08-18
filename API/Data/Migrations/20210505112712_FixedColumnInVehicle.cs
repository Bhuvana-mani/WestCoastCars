using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class FixedColumnInVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Make_MakeId",
                schema: "Vehicles",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleModel_ModelId",
                schema: "Vehicles",
                table: "Vehicle");

            migrationBuilder.AlterColumn<string>(
                name: "VehicleName",
                schema: "Vehicles",
                table: "Vehicle",
                type: "VARCHAR(80)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RegistrationNumber",
                schema: "Vehicles",
                table: "Vehicle",
                type: "VARCHAR(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModelId",
                schema: "Vehicles",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MakeId",
                schema: "Vehicles",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GearType",
                schema: "Vehicles",
                table: "Vehicle",
                type: "VARCHAR(40)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FuelType",
                schema: "Vehicles",
                table: "Vehicle",
                type: "VARCHAR(15)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                schema: "Vehicles",
                table: "Vehicle",
                type: "VARCHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Make_MakeId",
                schema: "Vehicles",
                table: "Vehicle",
                column: "MakeId",
                principalTable: "Make",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleModel_ModelId",
                schema: "Vehicles",
                table: "Vehicle",
                column: "ModelId",
                principalTable: "VehicleModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Make_MakeId",
                schema: "Vehicles",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleModel_ModelId",
                schema: "Vehicles",
                table: "Vehicle");

            migrationBuilder.AlterColumn<string>(
                name: "VehicleName",
                schema: "Vehicles",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RegistrationNumber",
                schema: "Vehicles",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModelId",
                schema: "Vehicles",
                table: "Vehicle",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MakeId",
                schema: "Vehicles",
                table: "Vehicle",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "GearType",
                schema: "Vehicles",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(40)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FuelType",
                schema: "Vehicles",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                schema: "Vehicles",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Make_MakeId",
                schema: "Vehicles",
                table: "Vehicle",
                column: "MakeId",
                principalTable: "Make",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleModel_ModelId",
                schema: "Vehicles",
                table: "Vehicle",
                column: "ModelId",
                principalTable: "VehicleModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
