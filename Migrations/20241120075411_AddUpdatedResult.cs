using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1_Web_App.Migrations
{
    /// <inheritdoc />
    public partial class AddUpdatedResult : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RaceId",
                table: "Result",
                newName: "Points");

            migrationBuilder.AddColumn<int>(
                name: "DriverId",
                table: "Result",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Result",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Result_DriverId",
                table: "Result",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_EventId",
                table: "Result",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Drivers_DriverId",
                table: "Result",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Events_EventId",
                table: "Result",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Result_Drivers_DriverId",
                table: "Result");

            migrationBuilder.DropForeignKey(
                name: "FK_Result_Events_EventId",
                table: "Result");

            migrationBuilder.DropIndex(
                name: "IX_Result_DriverId",
                table: "Result");

            migrationBuilder.DropIndex(
                name: "IX_Result_EventId",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "DriverId",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Result");

            migrationBuilder.RenameColumn(
                name: "Points",
                table: "Result",
                newName: "RaceId");
        }
    }
}
