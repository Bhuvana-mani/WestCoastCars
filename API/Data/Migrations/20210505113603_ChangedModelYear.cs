using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class ChangedModelYear : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "ModelYear",
                schema: "Vehicles",
                table: "Vehicle",
                type: "SMALLINT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ModelYear",
                schema: "Vehicles",
                table: "Vehicle",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "SMALLINT");
        }
    }
}
