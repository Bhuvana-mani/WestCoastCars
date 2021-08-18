using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class ChangedTableNameForVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Make_MakeId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleModel_ModelId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.EnsureSchema(
                name: "Vehicles");

            migrationBuilder.RenameTable(
                name: "Vehicles",
                newName: "Vehicle",
                newSchema: "Vehicles");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_ModelId",
                schema: "Vehicles",
                table: "Vehicle",
                newName: "IX_Vehicle_ModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_MakeId",
                schema: "Vehicles",
                table: "Vehicle",
                newName: "IX_Vehicle_MakeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicle",
                schema: "Vehicles",
                table: "Vehicle",
                column: "Id");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicle",
                schema: "Vehicles",
                table: "Vehicle");

            migrationBuilder.RenameTable(
                name: "Vehicle",
                schema: "Vehicles",
                newName: "Vehicles");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_ModelId",
                table: "Vehicles",
                newName: "IX_Vehicles_ModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_MakeId",
                table: "Vehicles",
                newName: "IX_Vehicles_MakeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Make_MakeId",
                table: "Vehicles",
                column: "MakeId",
                principalTable: "Make",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleModel_ModelId",
                table: "Vehicles",
                column: "ModelId",
                principalTable: "VehicleModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
