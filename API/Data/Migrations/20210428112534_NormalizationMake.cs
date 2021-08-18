using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
  public partial class NormalizationMake : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropColumn(
          name: "Make",
          table: "Vehicles");

      migrationBuilder.AddColumn<int>(
          name: "MakeId",
          table: "Vehicles",
          type: "int",
          nullable: true,
          defaultValue: 0);

      migrationBuilder.CreateTable(
          name: "Make",
          columns: table => new
          {
            Id = table.Column<int>(type: "int", nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
            Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Make", x => x.Id);
          });

      migrationBuilder.CreateIndex(
          name: "IX_Vehicles_MakeId",
          table: "Vehicles",
          column: "MakeId");

      migrationBuilder.AddForeignKey(
          name: "FK_Vehicles_Make_MakeId",
          table: "Vehicles",
          column: "MakeId",
          principalTable: "Make",
          principalColumn: "Id",
          onDelete: ReferentialAction.Cascade);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropForeignKey(
          name: "FK_Vehicles_Make_MakeId",
          table: "Vehicles");

      migrationBuilder.DropTable(
          name: "Make");

      migrationBuilder.DropIndex(
          name: "IX_Vehicles_MakeId",
          table: "Vehicles");

      migrationBuilder.DropColumn(
          name: "MakeId",
          table: "Vehicles");

      migrationBuilder.AddColumn<string>(
          name: "Make",
          table: "Vehicles",
          type: "nvarchar(max)",
          nullable: true);
    }
  }
}
