using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations.SmartERPDb
{
    public partial class ChangeVehicleConditionName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_vehicleCondition",
                table: "vehicleCondition");

            migrationBuilder.RenameTable(
                name: "vehicleCondition",
                newName: "VehicleCondition");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleCondition",
                table: "VehicleCondition",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleCondition",
                table: "VehicleCondition");

            migrationBuilder.RenameTable(
                name: "VehicleCondition",
                newName: "vehicleCondition");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vehicleCondition",
                table: "vehicleCondition",
                column: "Id");
        }
    }
}
