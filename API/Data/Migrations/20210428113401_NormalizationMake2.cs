using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
  public partial class NormalizationMake2 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropForeignKey(
          name: "FK_Vehicles_Make_MakeId",
          table: "Vehicles");

      migrationBuilder.AlterColumn<int>(
          name: "MakeId",
          table: "Vehicles",
          type: "int",
          nullable: true,
          oldClrType: typeof(int),
          oldType: "int");

      migrationBuilder.AddForeignKey(
          name: "FK_Vehicles_Make_MakeId",
          table: "Vehicles",
          column: "MakeId",
          principalTable: "Make",
          principalColumn: "Id",
          onDelete: ReferentialAction.NoAction);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropForeignKey(
          name: "FK_Vehicles_Make_MakeId",
          table: "Vehicles");

      migrationBuilder.AlterColumn<int>(
          name: "MakeId",
          table: "Vehicles",
          type: "int",
          nullable: false,
          defaultValue: 0,
          oldClrType: typeof(int),
          oldType: "int",
          oldNullable: true);

      migrationBuilder.AddForeignKey(
          name: "FK_Vehicles_Make_MakeId",
          table: "Vehicles",
          column: "MakeId",
          principalTable: "Make",
          principalColumn: "Id",
          onDelete: ReferentialAction.Cascade);
    }
  }
}
